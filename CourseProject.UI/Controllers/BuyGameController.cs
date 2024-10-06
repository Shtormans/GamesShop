using CourseProject.Application.Comments.Queries.GetCommentsByGame;
using CourseProject.Application.Games.Queries.GetGameById;
using CourseProject.Application.Games.Queries.GetGamesByUserLibrary;
using CourseProject.Application.Images.Queries.GetGameIcon;
using CourseProject.Application.Images.Queries.GetGameIcons;
using CourseProject.Application.Users.Commands.BuyGame;
using CourseProject.Application.Users.Queries.GetFriendsByGame;
using CourseProject.Application.Users.Queries.GetUsersByIds;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.Identificators;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;
using CourseProject.UI.Views.Home;
using MediatR;

namespace CourseProject.UI.Controllers;

internal class BuyGameController : BaseController
{
    const int TopCommentAmount = 5;

    public BuyGameController(ISender sender) 
        : base(sender)
    {
    }

    public async Task<BaseView> ShowGame(Guid gameId)
    {
        var gameQuery = new GetGameByIdQuery(GameId.Create(gameId).Value);
        var game = await Sender.Send(gameQuery);

        var gameIcon = await GetGameIcon(game.Value);

        GameModelWithImage gameModel = new()
        {
            Game = game.Value,
            Icon = gameIcon
        };

        ViewBag.GameModel = gameModel;

        return new BuyGameView(ViewBag);
    }

    public async Task<Image> GetGameIcon(Game game)
    {
        var query = new GetGameIconQuery(game.Image);
        var result = await Sender.Send(query);

        return result.Value;
    }

    public async Task<List<CommentWithAuthorImage>> GetNextComments(Game game, int skip)
    {
        var commentsQuery = new GetCommentsByGameQuery(game.Id, TopCommentAmount, (uint)skip);
        var comments = await Sender.Send(commentsQuery);

        var users = new List<User>(comments.Value.Count);
        foreach (var comment in comments.Value)
        {
            var userQuery = new GetUsersByIdQuery(comment.AuthorId);
            var user = await Sender.Send(userQuery);

            users.Add(user.Value);
        }

        var profilePicturesQuery = new GetProfilePicturesQuery(users.Select(user => user.ProfilePicture).ToList());
        var profilePictures = await Sender.Send(profilePicturesQuery);

        var result = new List<CommentWithAuthorImage>(comments.Value.Count);
        for (int i = 0; i < comments.Value.Count; i++)
        {
            result.Add(new CommentWithAuthorImage()
            {
                Comment = comments.Value[i],
                Author = users[i],
                AuthorPicture = profilePictures.Value[i]
            });
        }

        return result;
    }

    public async Task<List<UserWithProfilePicture>> GetNextFriends(Game game)
    {
        var currentUser = CurrentSessionController.Session.User;

        var friendsQuery = new GetFriendsByGameQuery(currentUser.Id, game.Id);
        var friends = await Sender.Send(friendsQuery);

        var profilePicturesQuery = new GetProfilePicturesQuery(friends.Value.Select(friend => friend.ProfilePicture).ToList());
        var profilePictures = await Sender.Send(profilePicturesQuery);

        var result = new List<UserWithProfilePicture>(friends.Value.Count);
        for (int i = 0; i < friends.Value.Count; i++)
        {
            result.Add(new UserWithProfilePicture()
            {
                User = friends.Value[i],
                ProfilePicture = profilePictures.Value[i]
            });
        }

        return result;
    }

    public async Task<bool> CheckIfGameIsAlreadyBought(Game game)
    {
        var currentUser = CurrentSessionController.Session.User;

        var libraryQuery = new GetGamesByUserLibraryQuery(currentUser.Id);
        var library = await Sender.Send(libraryQuery);

        return library.Value.Any(g => g.Id == game.Id);
    }

    public async Task<Result> BuyGame(Game game)
    {
        var currentUser = CurrentSessionController.Session.User;

        var buyGameCommand = new BuyGameCommand(currentUser.Id, currentUser.Id, game.Price, game.Id);
        var result = await Sender.Send(buyGameCommand);

        return result;
    }
}
