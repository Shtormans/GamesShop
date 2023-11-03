using CourseProject.Application.Abstractions.Messaging;
using System.Drawing;

namespace CourseProject.Application.Images.Queries.GetDefaultPicture;

public sealed record GetDefaultPictureQuery : IQuery<Image>;
