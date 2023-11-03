using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.User;

namespace CourseProject.Application.Users.Queries.GetUserByEmailOrUsername;

internal sealed class GetUserByEmailOrUsernameQueryHandler : IQueryHandler<GetUserByEmailOrUsernameQuery, User>
{
    private readonly IUserRepository _userRepository;

    public GetUserByEmailOrUsernameQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Result<User>> Handle(GetUserByEmailOrUsernameQuery request, CancellationToken cancellationToken)
    {
        User? user = null;

        var emailResult = UserEmail.Create(request.EmailOrUsername);
        if (emailResult.IsSuccess)
        {
            user = await _userRepository.GetByEmailAsync(emailResult.Value.Value, cancellationToken);
        }
        else
        {
            var usernameResult = Username.Create(request.EmailOrUsername);
            if (usernameResult.IsFailure)
            {
                return Result.Failure<User>(usernameResult.Error);
            }

            user = await _userRepository.GetByUsernameAsync(usernameResult.Value.Value, cancellationToken);
        }

        if (user is null)
        {
            return Result.Failure<User>(DomainErrors.User.WrongEmailOrUsername(request.EmailOrUsername));
        }

        return user;
    }
}
