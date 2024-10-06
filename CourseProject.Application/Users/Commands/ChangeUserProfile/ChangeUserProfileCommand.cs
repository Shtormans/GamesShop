using CourseProject.Application.Abstractions.Messaging;
using System.Drawing;

namespace CourseProject.Application.Users.Commands.ChangeUserProfile;

public sealed record ChangeUserProfileCommand(Guid UserId, string? FirstName, string? SecondName, DateTime Birthday, Image ProfilePicture) : ICommand;
