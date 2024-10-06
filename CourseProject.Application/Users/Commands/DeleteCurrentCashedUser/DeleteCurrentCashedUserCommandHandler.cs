using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;

namespace CourseProject.Application.Users.Commands.DeleteCurrentCashedUser;

internal class DeleteCurrentCashedUserCommandHandler : ICommandHandler<DeleteCurrentCashedUserCommand>
{
    private readonly ICashRepository _cashRepository;

    public DeleteCurrentCashedUserCommandHandler(ICashRepository cashRepository)
    {
        _cashRepository = cashRepository;
    }

    public async Task<Result> Handle(DeleteCurrentCashedUserCommand request, CancellationToken cancellationToken)
    {
        await _cashRepository.DeleteCashedUser();

        return Result.Success();
    }
}
