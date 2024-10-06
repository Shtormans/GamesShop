using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Abstractions;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;

namespace CourseProject.Application.Users.Commands.AddFriend;

internal class AddFriendCommandHandler : ICommandHandler<AddFriendCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddFriendCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(AddFriendCommand request, CancellationToken cancellationToken)
    {
        if (request.FirstUserId == request.SecondUserId)
        {
            return Result.Failure(DomainErrors.User.CantBeFriendsWithYourself);
        }

        var firstUser = await _userRepository.GetByIdWithTrackingAsync(request.FirstUserId);
        if (firstUser is null)
        {
            return Result.Failure(DomainErrors.User.WrongId);
        }

        var secondUser = await _userRepository.GetByIdWithTrackingAsync(request.SecondUserId);
        if (secondUser is null)
        {
            return Result.Failure(DomainErrors.User.WrongId);
        }

        firstUser.AddFriend(secondUser);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}
