using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;

namespace CourseProject.Application.Users.Queries.GetCurrentUser;

internal class GetCurrentUserQueryHandler : IQueryHandler<GetCurrentUserQuery, User>
{
    private readonly ICashRepository _cashRepository;

    public GetCurrentUserQueryHandler(ICashRepository cashRepository)
    {
        _cashRepository = cashRepository;
    }

    public async Task<Result<User>> Handle(GetCurrentUserQuery request, CancellationToken cancellationToken)
    {
        User? user = await _cashRepository.GetUser();
        if (user is null)
        {
            return Result.Failure<User>(DomainErrors.User.NoCahedAccount);
        }


        return Result.Success(user);
    }
}
