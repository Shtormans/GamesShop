using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Abstractions;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.Game;
using CourseProject.Domain.ValueObjects.Identificators;

namespace CourseProject.Application.Games.Commands.PublishGame;

internal class PublishGameCommandHandler : ICommandHandler<PublishGameCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IGameRepository _gameRepository;
    private readonly ICashRepository _cashRepository;
    private readonly IUnitOfWork _unitOfWork;

    public PublishGameCommandHandler(
        IUserRepository userRepository,
        IGameRepository gameRepository,
        ICashRepository cashRepository,
        IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _gameRepository = gameRepository;
        _cashRepository = cashRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(PublishGameCommand request, CancellationToken cancellationToken)
    {
        var gameTitleResult = GameTitle.Create(request.Title);
        if (gameTitleResult.IsFailure)
        {
            return Result.Failure<GameId>(gameTitleResult.Error);
        }

        var gameCreationDateResult = GameCreationDate.Create(request.CreationDate);
        if (gameCreationDateResult.IsFailure)
        {
            return Result.Failure<GameId>(gameCreationDateResult.Error);
        }

        if (request.Price.Amount <= 0)
        {
            return Result.Failure<GameId>(DomainErrors.Price.IncorrectPrice);
        }

        var gameDescriptionResult = GameDescription.Create(request.Description);
        if (gameDescriptionResult.IsFailure)
        {
            return Result.Failure<GameId>(gameDescriptionResult.Error);
        }

        var author = await _userRepository.GetByIdAsync(request.AuthorId.Value, cancellationToken);
        if (author is null)
        {
            return Result.Failure<GameId>(DomainErrors.User.WrongId);
        }

        var gameWithSameTitleResult = await _gameRepository.GetByTitleAsync(gameTitleResult.Value, cancellationToken);
        if (gameWithSameTitleResult is not null)
        {
            return Result.Failure<GameId>(DomainErrors.Game.TitleAlreadyExist(gameTitleResult.Value));
        }

        var imageResult = GameIcon.Create(Guid.NewGuid());
        Task.Run(() => _cashRepository.UploadGameIcon(imageResult.Value.Id.ToString(), request.Icon));

        var game = Game.Create(
            gameTitleResult.Value,
            gameCreationDateResult.Value,
            request.Price,
            UserId.Create(author.Id).Value,
            gameDescriptionResult.Value,
            imageResult.Value
        );

        _gameRepository.Add(game);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return GameId.Create(game.Id);
    }
}
