using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Abstractions;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.Game;
using CourseProject.Domain.ValueObjects.Identificators;

namespace CourseProject.Application.Games.Commands.PublishGame;

internal class PublishGameCommandHandler : ICommandHandler<PublishGameCommand, GameId>
{
    private readonly IUserRepository _userRepository;
    private readonly IGameRepository _gameRepository;
    private readonly IUnitOfWork _unitOfWork;

    public PublishGameCommandHandler(
        IUserRepository userRepository,
        IGameRepository gameRepository,
        IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _gameRepository = gameRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<GameId>> Handle(PublishGameCommand request, CancellationToken cancellationToken)
    {
        var gameTitleResult = GameTitle.Create(request.Title);
        if (gameTitleResult.IsFailure)
        {
            return Result.Failure<GameId>(gameTitleResult.Error);
        }

        if (request.Price.Amount <= 0)
        {
            return Result.Failure<GameId>(DomainErrors.Price.IncorrectPrice);
        }

        var gameDesriptionResult = GameDescription.Create(request.Description);
        if (gameDesriptionResult.IsFailure)
        {
            return Result.Failure<GameId>(gameDesriptionResult.Error);
        }

        var author = await _userRepository.GetByIdAsync(request.AuthorId.Value, cancellationToken);
        if (author is null)
        {
            return Result.Failure<GameId>(DomainErrors.User.WrongId);
        }

        var game = Game.Create(
            gameTitleResult.Value,
            request.Price,
            UserId.Create(author.Id).Value,
            gameDesriptionResult.Value,
            request.ImageId
        );

        _gameRepository.Add(game);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return GameId.Create(game.Id);
    }
}
