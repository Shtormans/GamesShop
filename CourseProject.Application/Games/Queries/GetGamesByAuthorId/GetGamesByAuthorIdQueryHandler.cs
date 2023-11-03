using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;

namespace CourseProject.Application.Games.Queries.GetGamesByAuthorId;

internal class GetGamesByAuthorIdQueryHandler : IQueryHandler<GetGamesByAuthorIdQuery, List<Game>>
{
    private readonly IGameRepository _gameRepository;
    private readonly IUserRepository _userRepository;

    public GetGamesByAuthorIdQueryHandler(IGameRepository gameRepository, IUserRepository userRepository)
    {
        _gameRepository = gameRepository;
        _userRepository = userRepository;
    }

    public async Task<Result<List<Game>>> Handle(GetGamesByAuthorIdQuery request, CancellationToken cancellationToken)
    {
        var author = await _userRepository.GetByIdAsync(request.AuthorId);
        if (author is null)
        {
            return Result.Failure<List<Game>>(DomainErrors.User.WrongId);
        }

        var games = await _gameRepository.GetByAuthorIdAsync(author.Id, cancellationToken);

        return games;
    }
}
