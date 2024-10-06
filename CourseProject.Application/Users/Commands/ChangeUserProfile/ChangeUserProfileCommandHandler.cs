using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.Game;
using CourseProject.Domain.ValueObjects.User;

namespace CourseProject.Application.Users.Commands.ChangeUserProfile;

internal class ChangeUserProfileCommandHandler : ICommandHandler<ChangeUserProfileCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly ICashRepository _cashRepository;

    public ChangeUserProfileCommandHandler(IUserRepository userRepository, ICashRepository cashRepository)
    {
        _userRepository = userRepository;
        _cashRepository = cashRepository;
    }

    public async Task<Result> Handle(ChangeUserProfileCommand request, CancellationToken cancellationToken)
    {
        var oldUserProfile = await _userRepository.GetByIdAsync(request.UserId);
        if (oldUserProfile is null)
        {
            return Result.Failure(DomainErrors.User.WrongId);
        }

        UserFirstName? firstName = null;
        if (request.FirstName is not null)
        {
            var firstNameResult = UserFirstName.Create(request.FirstName);
            if (firstNameResult.IsFailure)
            {
                return Result.Failure(firstNameResult.Error);
            }

            firstName = firstNameResult.Value;
        }

        UserSecondName? secondName = null;
        if (request.SecondName is not null)
        {
            var secondNameResult = UserSecondName.Create(request.SecondName);
            if (secondNameResult.IsFailure)
            {
                return Result.Failure(secondNameResult.Error);
            }

            secondName = secondNameResult.Value;
        }

        var userBirthdayResult = UserBirthday.Create(request.Birthday);
        if (userBirthdayResult.IsFailure)
        {
            return Result.Failure(userBirthdayResult.Error);
        }

        Task.Run(() => _cashRepository.UploadProfilePicture(oldUserProfile.ProfilePicture.Id.ToString(), request.ProfilePicture));

        var newUser = User.Create(
            oldUserProfile.Username,
            oldUserProfile.Email,
            oldUserProfile.Password,
            userBirthdayResult.Value,
            oldUserProfile.ProfilePicture,
            firstName,
            secondName
        );

        await _userRepository.Update(oldUserProfile, newUser);

        return Result.Success();
    }
}
