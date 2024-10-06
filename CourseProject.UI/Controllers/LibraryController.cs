using CourseProject.Application.Comments.Commands.CreateCommand;
using CourseProject.Application.Comments.Queries.GetCommentsByGame;
using CourseProject.Application.Games.Queries.GetGamesByUserLibrary;
using CourseProject.Application.Images.Queries.GetGameIcon;
using CourseProject.Application.Images.Queries.GetGameIcons;
using CourseProject.Application.Users.Queries.GetFriendsByGame;
using CourseProject.Application.Users.Queries.GetUsersByIds;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.Identificators;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;
using MediatR;

namespace CourseProject.UI.Controllers;

internal class LibraryController : BaseController
{
    const int TopCommentAmount = 5;

    public LibraryController(ISender sender) 
        : base(sender)
    {
    }

    public async Task<List<Game>> GetUserLibrary()
    {
        var user = CurrentSessionController.Session.User;

        var libraryQuery = new GetGamesByUserLibraryQuery(user.Id);
        var library = await Sender.Send(libraryQuery);

        return library.Value;
    }

    public async Task<Image> GetGameIcon(Game game)
    {
        var query = new GetGameIconQuery(game.Image);
        var result = await Sender.Send(query);

        return result.Value;
    }

    public async Task<Result> CreateComment(Game game, string commentText)
    {
        var user = CurrentSessionController.Session.User;

        var query = new CreateCommentCommand(commentText, UserId.Create(user.Id).Value, GameId.Create(game.Id).Value);
        var result = await Sender.Send(query);

        return result;
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
}
