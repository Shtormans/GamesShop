using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;

namespace CourseProject.Application.Comments.Queries.GetCommentsByGame;

internal class GetCommentsByGameQueryHandler : IQueryHandler<GetCommentsByGameQuery, List<Comment>>
{
    private readonly ICommentRepository _commentRepository;
    private readonly IGameRepository _gameRepository;

    public GetCommentsByGameQueryHandler(ICommentRepository commentRepository, IGameRepository gameRepository)
    {
        _commentRepository = commentRepository;
        _gameRepository = gameRepository;
    }

    public async Task<Result<List<Comment>>> Handle(GetCommentsByGameQuery request, CancellationToken cancellationToken)
    {
        var game = await _gameRepository.GetByIdAsync(request.GameId, cancellationToken);
        if (game is null)
        {
            return Result.Failure<List<Comment>>(DomainErrors.Game.WrongId);
        }

        var comments = await _commentRepository.GetByGameIdAsync(game.Id, (int)request.Take, (int)request.Skip, cancellationToken);

        return comments;
    }
}
