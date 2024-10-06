using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;

namespace CourseProject.Application.Users.Queries.GetFriendsByUserId;

internal class GetFriendsByUserIdQueryHandler : IQueryHandler<GetFriendsByUserIdQuery, List<User>>
{
    private readonly IUserRepository _userRepository;

    public GetFriendsByUserIdQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Result<List<User>>> Handle(GetFriendsByUserIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(request.UserId);
        if (user is null)
        {
            return Result.Failure<List<User>>(DomainErrors.User.WrongId);
        }

        var friends = await _userRepository.GetFriendsByUserIdAsync(request.UserId);

        return friends;
    }
}
