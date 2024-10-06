using CourseProject.Application.Games.Queries.GetGamesByUserLibrary;
using CourseProject.Application.Images.Queries;
using CourseProject.Application.Images.Queries.GetGameIcons;
using CourseProject.Application.Users.Commands.AddFriend;
using CourseProject.Application.Users.Queries.GetFriendsByUserId;
using CourseProject.Application.Users.Queries.GetUsersByUsername;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Shared;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;
using MediatR;

namespace CourseProject.UI.Controllers;

internal class FriendsController : BaseController
{
    public const int TopAmount = 10;

    public FriendsController(ISender sender) 
        : base(sender)
    {
    }

    public async Task<List<GameModelWithImage>> GetNextGames(User user)
    {
        var storeQuery = new GetGamesByUserLibraryQuery(user.Id);
        var games = await Sender.Send(storeQuery);

        var gameIconsQuery = new GetGameIconsQuery(games.Value.Select(game => game.Image).ToList());
        var gameIcons = await Sender.Send(gameIconsQuery);

        var result = new List<GameModelWithImage>(games.Value.Count);
        for (int i = 0; i < games.Value.Count; i++)
        {
            result.Add(new GameModelWithImage()
            {
                Game = games.Value[i],
                Icon = gameIcons.Value[i]
            });
        }

        return result;
    }

    public async Task<List<User>> GetCurrentUserFriends()
    {
        var currentUser = CurrentSessionController.Session.User;

        var friendsQuery = new GetFriendsByUserIdQuery(currentUser.Id);
        var friends = await Sender.Send(friendsQuery);

        return friends.Value;
    }

    public async Task<List<UserWithProfilePicture>> GetNextFriends(User user)
    {
        var friendsQuery = new GetFriendsByUserIdQuery(user.Id);
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

    public async Task<Image> GetFriendProfilePicture(User user)
    {
        var profilePictureQuery = new GetProfilePictureQuery(user.ProfilePicture);
        var profilePicture = await Sender.Send(profilePictureQuery);

        return profilePicture.Value;
    }

    public async Task<List<UserWithProfilePicture>> FindUsers(string username, int skip)
    {
        var currentUser = CurrentSessionController.Session.User;

        var usersQuery = new GetUsersByUsernameQuery(username, (uint)skip, TopAmount);
        var users = await Sender.Send(usersQuery);

        if (users.IsFailure)
        {
            return new List<UserWithProfilePicture>();
        }

        var resultUsers = users.Value.Where(u => u.Id != currentUser.Id).ToList();

        var profilePicturesQuery = new GetProfilePicturesQuery(resultUsers.Select(friend => friend.ProfilePicture).ToList());
        var profilePictures = await Sender.Send(profilePicturesQuery);

        var result = new List<UserWithProfilePicture>(resultUsers.Count);
        for (int i = 0; i < resultUsers.Count; i++)
        {
            result.Add(new UserWithProfilePicture()
            {
                User = resultUsers[i],
                ProfilePicture = profilePictures.Value[i]
            });
        }

        return result;
    }

    public async Task<Result> AddFriend(Guid userId)
    {
        var currentUser = CurrentSessionController.Session.User;

        var addFriendCommand = new AddFriendCommand(currentUser.Id, userId);
        var result = await Sender.Send(addFriendCommand);

        return result;
    }
}
