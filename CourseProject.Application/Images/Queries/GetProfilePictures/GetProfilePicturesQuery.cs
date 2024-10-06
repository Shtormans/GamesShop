using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.ValueObjects.User;
using System.Drawing;

namespace CourseProject.Application.Images.Queries.GetGameIcons;

public sealed record GetProfilePicturesQuery(List<UserProfilePicture> ProfilePictures) : IQuery<List<Image>>;
