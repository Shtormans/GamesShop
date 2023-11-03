using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;

namespace CourseProject.Application.Games.Queries.GetGameById;

internal class GetGameByIdQueryHandler : IQueryHandler<GetGameByIdQuery, Game>
{
    private readonly IGameRepository _gameRepository;

    public GetGameByIdQueryHandler(IGameRepository gameRepository)
    {
        _gameRepository = gameRepository;
    }

    public async Task<Result<Game>> Handle(GetGameByIdQuery request, CancellationToken cancellationToken)
    {
        Guid gameId = request.GameId.Value;

        var game = await _gameRepository.GetByIdAsync(gameId, cancellationToken);

        if (game is null)
        {
            return Result.Failure<Game>(DomainErrors.Game.WrongId);
        }

        return game;
    }
}
