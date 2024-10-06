using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.User;

namespace CourseProject.Application.Users.Queries.GetUsersByUsername;

internal class GetUsersByUsernameQueryHandler : IQueryHandler<GetUsersByUsernameQuery, List<User>>
{
    private readonly IUserRepository _userRepository;

    public GetUsersByUsernameQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Result<List<User>>> Handle(GetUsersByUsernameQuery request, CancellationToken cancellationToken)
    {
        var usernameResult = Username.Create(request.Username);
        if (usernameResult.IsFailure)
        {
            return Result.Failure<List<User>>(usernameResult.Error);
        }

        var users = await _userRepository.GetUsersByUsernameAsync(usernameResult.Value, (int)request.Skip, (int)request.Take, cancellationToken);

        return users;
    }
}
