using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;

namespace CourseProject.Application.Users.Commands.CashCurrentUser;

public sealed class CashCurrentUserCommandHandler : ICommandHandler<CashCurrentUserCommand>
{
    private readonly ICashRepository _cashRepository;

    public CashCurrentUserCommandHandler(ICashRepository cashRepository)
    {
        _cashRepository = cashRepository;
    }

    public async Task<Result> Handle(CashCurrentUserCommand request, CancellationToken cancellationToken)
    {
        await _cashRepository.CashUser(request.User);

        return Result.Success();
    }
}
