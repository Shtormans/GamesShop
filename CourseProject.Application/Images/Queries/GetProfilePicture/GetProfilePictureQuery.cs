using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.ValueObjects.User;
using System.Drawing;

namespace CourseProject.Application.Images.Queries;

public sealed record GetProfilePictureQuery(UserProfilePicture ProfilePicture) : IQuery<Image>;
