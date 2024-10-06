using CourseProject.Application.Abstractions.Messaging;

namespace CourseProject.Application.Users.Commands.AddFriend;

public sealed record AddFriendCommand(Guid FirstUserId, Guid SecondUserId) : ICommand;
