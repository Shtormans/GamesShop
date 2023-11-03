using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.Game;
using CourseProject.Domain.ValueObjects.Identificators;

namespace CourseProject.Application.Games.Commands.ChangeGame;

internal class ChangeGameCommandHandler : ICommandHandler<ChangeGameCommand>
{
    private readonly IGameRepository _gameRepository;
    private readonly ICashRepository _cashRepository;

    public ChangeGameCommandHandler(IGameRepository gameRepository, ICashRepository cashRepository)
    {
        _gameRepository = gameRepository;
        _cashRepository = cashRepository;        
    }

    public async Task<Result> Handle(ChangeGameCommand request, CancellationToken cancellationToken)
    {
        var oldGame = await _gameRepository.GetByIdAsync(request.GameId);
        if (oldGame is null)
        {
            return Result.Failure(DomainErrors.Game.WrongId);
        }

        var gameTitleResult = GameTitle.Create(request.Title);
        if (gameTitleResult.IsFailure)
        {
            return Result.Failure(gameTitleResult.Error);
        }

        var gameDescriptionResult = GameDescription.Create(request.Description);
        if (gameDescriptionResult.IsFailure)
        {
            return Result.Failure(gameDescriptionResult.Error);
        }

        if (request.Price.Amount <= 0)
        {
            return Result.Failure<GameId>(DomainErrors.Price.IncorrectPrice);
        }

        Task.Run(() => _cashRepository.UploadGameIcon(oldGame.Image.Id.ToString(), request.Icon));

        var newGame = Game.Create(
            gameTitleResult.Value,
            oldGame.CreationDate,
            request.Price,
            UserId.Create(oldGame.AuthorId).Value,
            gameDescriptionResult.Value,
            oldGame.Image
        );

        await _gameRepository.UpdateGame(oldGame, newGame);

        return Result.Success();
    }
}
