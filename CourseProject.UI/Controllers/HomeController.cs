using CourseProject.Application.Games.Queries.GetGamesByTitleAndSortModifier;
using CourseProject.Application.Images.Queries;
using CourseProject.Application.Images.Queries.GetGameIcons;
using CourseProject.Application.Users.Queries.GetCurrentUser;
using CourseProject.Domain.Enums;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Managers;
using CourseProject.UI.StaticData;
using CourseProject.UI.Views;
using MediatR;

namespace CourseProject.UI.Controllers;

internal class HomeController : BaseController
{
    public HomeController(ISender sender) 
        : base(sender)
    {
    }
    public async Task<BaseView> Index()
    {
        await UIManager.Instance.ChangeUISettings(
            new Settings.BrowserSettings()
            {
                ScreenSize = Sizes.HomeScreenSize
            });

        var query = new GetCurrentUserQuery();

        var userResult = await Sender.Send(query);
        var user = userResult.Value;
        CurrentSessionContoller.SetNewSession(user);

        var pictureQuery = new GetProfilePictureQuery(user.ProfilePicture);
        var pictureResult = await Sender.Send(pictureQuery).ConfigureAwait(false);

        ViewBag.Username = user.Username.Value;
        ViewBag.AccountPicture = pictureResult.Value;

        return new HomeView(ViewBag);
    }
}
