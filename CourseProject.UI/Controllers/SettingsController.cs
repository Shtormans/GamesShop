using CourseProject.Application.Images.Queries;
using CourseProject.Application.Transactions.Queries.GetTransactionsByGameCreatorWithGames;
using CourseProject.Application.Users.Commands.ChangeUserProfile;
using CourseProject.Application.Users.Commands.DeleteCurrentCashedUser;
using CourseProject.Application.Users.Queries.GetUsersByIds;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Enums;
using CourseProject.Domain.Shared;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Managers;
using MediatR;

namespace CourseProject.UI.Controllers;

internal class SettingsController : BaseController
{
    public SettingsController(ISender sender)
        : base(sender)
    {
    }

    public async Task<Result> LogOut()
    {
        var command = new DeleteCurrentCashedUserCommand();
        await Sender.Send(command);

        await UIManager.Instance.ShowView(nameof(LoginController), "ShowLoginForm");

        return Result.Success();
    }

    public async Task<Image> GetProfilePicture()
    {
        var currentUser = CurrentSessionController.Session.User;

        var query = new GetProfilePictureQuery(currentUser.ProfilePicture);
        var result = await Sender.Send(query);

        return result.Value;
    }

    public async Task<Result> UpdateProfile(string? firstName, string? secondName, DateTime birthday, Image profilePicture)
    {
        var currentUser = CurrentSessionController.Session.User;

        var command = new ChangeUserProfileCommand(currentUser.Id, firstName, secondName, birthday, profilePicture);
        var result = await Sender.Send(command);

        return result;
    }

    public async Task<User> GetCurrentUser()
    {
        var currentUser = CurrentSessionController.Session.User;

        var query = new GetUsersByIdQuery(currentUser.Id);
        var user = await Sender.Send(query);

        return user.Value;
    }

    public async Task<Result> ChangeLanguage(string language)
    {
        UpdateAppSettings<string>("Language", language);

        return Result.Success();
    }

    public async Task<Result> ChangeCurrency(CurrencyType currencyType)
    {
        UpdateAppSettings<string>("Currency", currencyType.ToString());

        return Result.Success();
    }

    private void UpdateAppSettings<TValue>(string key, TValue value)
    {
        var filePath = Path.Combine(AppContext.BaseDirectory, "appSettings.json");

        string json = File.ReadAllText(filePath);

        dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

        var sectionPath = key.Split(":")[0];

        jsonObj[sectionPath] = value;

        string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);

        File.WriteAllText(filePath, output);
    }

    public async Task<List<Transaction>> GetBuyingStatisics(DateTime fromDate, DateTime toDate)
    {
        var currentUser = CurrentSessionController.Session.User;

        var query = new GetTransactionsByGameCreatorWithGamesQuery(currentUser.Id, fromDate, toDate);
        var result = await Sender.Send(query);

        return result.Value;
    }
}
