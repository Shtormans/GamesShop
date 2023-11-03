using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Abstractions;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.User;

namespace CourseProject.Application.Users.Commands.CreateUser;

internal class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, User>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<User>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var emailResult = UserEmail.Create(request.Email);
        if (emailResult.IsFailure)
        {
            return Result.Failure<User>(emailResult.Error);
        }

        var usernameResult = Username.Create(request.Username);
        if (usernameResult.IsFailure)
        {
            return Result.Failure<User>(usernameResult.Error);
        }

        var passwordResult = UserPassword.Create(request.Password);
        if (passwordResult.IsFailure)
        {
            return Result.Failure<User>(passwordResult.Error);
        }

        var birthdayResult = UserBirthday.Create(request.Birthday);
        if (birthdayResult.IsFailure)
        {
            return Result.Failure<User>(birthdayResult.Error);
        }

        UserFirstName? firstName = null;
        if (request.FirstName is not null)
        {
            var firstNameResult = UserFirstName.Create(request.FirstName);
            if (firstNameResult.IsFailure)
            {
                return Result.Failure<User>(firstNameResult.Error);
            }

            firstName = firstNameResult.Value;
        }

        UserSecondName? secondName = null;
        if (request.SecondName is not null)
        {
            var secondNameResult = UserSecondName.Create(request.SecondName);
            if (secondNameResult.IsFailure)
            {
                return Result.Failure<User>(secondNameResult.Error);
            }

            secondName = secondNameResult.Value;
        }

        var userImage = UserProfilePicture.Create(Guid.NewGuid()).Value;

        var user = await _userRepository.GetByEmailAsync(request.Email);
        if (user is not null)
        {
            return Result.Failure<User>(DomainErrors.User.EmailAlreadyExist(emailResult.Value.Value));
        }

        user = await _userRepository.GetByUsernameAsync(request.Username);
        if (user is not null)
        {
            return Result.Failure<User>(DomainErrors.User.EmailAlreadyExist(usernameResult.Value.Value));
        }

        var userModel = User.Create(
            usernameResult.Value,
            emailResult.Value,
            passwordResult.Value,
            birthdayResult.Value,
            userImage,
            firstName,
            secondName
        );

        _userRepository.Add(userModel);

        await _unitOfWork.SaveChangesAsync();

        var resultUser = await _userRepository.GetByIdAsync(userModel.Id);

        return resultUser;
    }
}
