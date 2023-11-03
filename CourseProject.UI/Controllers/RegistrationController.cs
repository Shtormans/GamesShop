using CourseProject.Application.Users.Commands.CashCurrentUser;
using CourseProject.Application.Users.Commands.CreateUser;
using CourseProject.Application.Users.Queries.GetUserByEmailOrUsername;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.User;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;
using CourseProject.UI.StaticData;
using CourseProject.UI.Views.Registration;
using MediatR;

namespace CourseProject.UI.Controllers;

internal class RegistrationController : BaseController
{
    public RegistrationController(ISender sender) 
        : base(sender)
    {
    }

    public async Task<BaseView> ShowFirstRegistrationForm()
    {
        return new FirstRegistrationView(ViewBag);
    }

    public async Task<BaseView> ShowNextRegistrationForm(string email)
    {
        ViewBag.Email = email;

        await UIManager.Instance.ChangeUISettings(
            new Settings.BrowserSettings()
            {
                ScreenSize = Sizes.DataInputRegistrationForm
            });

        return new FullRegistrationView(ViewBag);
    }

    public async Task<Result> CheckIfEmailAlreadyExistInUsers(string email)
    {
        var userEmailResult = UserEmail.Create(email);
        if (userEmailResult.IsFailure)
        {
            return Result.Failure(userEmailResult.Error);
        }

        var query = new GetUserByEmailOrUsernameQuery(userEmailResult.Value.Value);

        var userResult = await Sender.Send(query);

        if (userResult.IsSuccess)
        {
            return Result.Failure(DomainErrors.User.EmailAlreadyExist(userEmailResult.Value.Value));
        }

        return Result.Success();
    }

    public async Task<Result> RegisterUser(
    string username,
    string email,
    string password,
    DateTime dateOfBirth,
    string? firstName = null,
    string? lastName = null)
    {
        var command = new CreateUserCommand(username, email, password, dateOfBirth, firstName, lastName);

        var userResult = await Sender.Send(command);

        if (userResult.IsSuccess)
        {
            var cashCommand = new CashCurrentUserCommand(userResult.Value);
            await Sender.Send(cashCommand);

            await UIManager.Instance.ShowView(nameof(HomeController));

            return Result.Success();
        }

        return userResult;
    }
}
