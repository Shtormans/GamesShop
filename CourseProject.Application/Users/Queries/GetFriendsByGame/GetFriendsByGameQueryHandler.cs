using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;

namespace CourseProject.Application.Users.Queries.GetFriendsByGame;

internal class GetFriendsByGameQueryHandler : IQueryHandler<GetFriendsByGameQuery, List<User>>
{
    private readonly IUserRepository _userRepository;
    private readonly IGameRepository _gameRepository;

    public GetFriendsByGameQueryHandler(IUserRepository userRepository, IGameRepository gameRepository)
    {
        _userRepository = userRepository;
        _gameRepository = gameRepository;
    }

    public async Task<Result<List<User>>> Handle(GetFriendsByGameQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(request.UserId, cancellationToken);
        if (user is null)
        {
            return Result.Failure<List<User>>(DomainErrors.User.WrongId);
        }

        var game = await _gameRepository.GetByIdAsync(request.GameId, cancellationToken);
        if (game is null)
        {
            return Result.Failure<List<User>>(DomainErrors.Game.WrongId);
        }

        var friends = await _userRepository.GetFriendsByGame(user.Id, game.Id, cancellationToken);
        return friends;
    }
}
