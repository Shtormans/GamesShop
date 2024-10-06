using CourseProject.Application.Images.Queries;
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


        var user = CurrentSessionController.Session.User;

        var pictureQuery = new GetProfilePictureQuery(user.ProfilePicture);
        var pictureResult = await Sender.Send(pictureQuery).ConfigureAwait(false);

        ViewBag.Username = user.Username.Value;
        ViewBag.AccountPicture = pictureResult.Value;

        return new HomeView(ViewBag);
    }
}
