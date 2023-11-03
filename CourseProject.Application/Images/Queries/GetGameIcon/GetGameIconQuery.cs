using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.ValueObjects.Game;
using System.Drawing;

namespace CourseProject.Application.Images.Queries.GetGameIcon;

public sealed record GetGameIconQuery(GameIcon GameIcon) : IQuery<Image>;
