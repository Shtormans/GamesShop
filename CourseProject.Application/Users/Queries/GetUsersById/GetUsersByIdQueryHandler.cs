using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;

namespace CourseProject.Application.Users.Queries.GetUsersByIds;

internal class GetUsersByIdQueryHandler : IQueryHandler<GetUsersByIdQuery, User>
{
    private readonly IUserRepository _userRepository;

    public GetUsersByIdQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Result<User>> Handle(GetUsersByIdQuery request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(request.UserId, cancellationToken);
        if (user is null)
        {
            return Result.Failure<User>(DomainErrors.User.WrongId);
        }

        return user;
    }
}
