using CourseProject.Application.Games.Commands.ChangeGame;
using CourseProject.Application.Games.Commands.PublishGame;
using CourseProject.Application.Games.Queries.GetGamesByAuthorId;
using CourseProject.Application.Images.Queries.GetDefaultPicture;
using CourseProject.Application.Images.Queries.GetGameIcon;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Enums;
using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.Identificators;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Managers;
using MediatR;

namespace CourseProject.UI.Controllers;

internal class MyGamesController : BaseController
{
    public MyGamesController(ISender sender) 
        : base(sender)
    {
    }

    public async Task<List<Game>> GetUserCreatedGames()
    {
        var user = CurrentSessionController.Session.User;

        var query = new GetGamesByAuthorIdQuery(user.Id);
        var result = await Sender.Send(query);

        return result.Value;
    }

    public async Task<Image> GetDefaultImage()
    {
        var query = new GetDefaultPictureQuery();
        var result = await Sender.Send(query);

        return result.Value;
    }

    public async Task<Image> GetGameIcon(Game game)
    {
        var query = new GetGameIconQuery(game.Image);
        var result = await Sender.Send(query);

        return result.Value;
    }

    public async Task<Result> PublishGame(string title, string description, GameGenre genre, Money price, Image icon)
    {
        var user = CurrentSessionController.Session.User;

        var command = new PublishGameCommand(title, DateTime.UtcNow, price, genre, UserId.Create(user.Id).Value, description, icon);
        var result = await Sender.Send(command);

        return result;
    }

    public async Task<Result> UpdateGame(Guid id, string title, string description, GameGenre genre, Money price, Image icon)
    {
        var command = new ChangeGameCommand(id, title, genre, description, price, icon);
        var result = await Sender.Send(command);

        return result;
    }
}
