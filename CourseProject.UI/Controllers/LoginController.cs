using CourseProject.Application.Users.Commands.CashCurrentUser;
using CourseProject.Application.Users.Commands.CreateUser;
using CourseProject.Application.Users.Queries.GetCurrentUser;
using CourseProject.Application.Users.Queries.GetUserByEmailOrUsername;
using CourseProject.Domain.Entities;
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

internal class LoginController : BaseController
{
    public LoginController(ISender sender)
        : base(sender)
    {
    }

    public async Task<BaseView> ShowLoginForm()
    {
        await UIManager.Instance.ChangeUISettings(
            new Settings.BrowserSettings()
            {
                ScreenSize = Sizes.RegistrationForm,
                IsLocked = true
            });

        return new LoginView(ViewBag);
    }

    public async Task<Result> LoginUser(string emailOrUsername, string password, bool rememberMe)
    {
        var userResult = await CheckUser(emailOrUsername, password);
        if (userResult.IsSuccess)
        {
            if (rememberMe)
            {
                var command = new CashCurrentUserCommand(userResult.Value);
                await Sender.Send(command);
            }

            CurrentSessionController.SetNewSession(new ChangeSessionModel()
            {
                User = userResult.Value
            });

            await UIManager.Instance.ShowView(nameof(HomeController));

            return Result.Success();
        }

        return Result.Failure(userResult.Error);
    }

    private async Task<Result<User>> CheckUser(string emailOrUsername, string password)
    {
        var userQuery = new GetUserByEmailOrUsernameQuery(emailOrUsername);

        var userResult = await Sender.Send(userQuery);

        if (userResult.IsSuccess)
        {
            var passwordResult = UserPassword.Create(password);
            if (passwordResult.IsFailure)
            {
                return Result.Failure<User>(passwordResult.Error);
            }

            if (userResult.Value.Password != passwordResult.Value)
            {
                return Result.Failure<User>(DomainErrors.User.WrongPassword);
            }

            return userResult;
        }

        return userResult;
    }
}
