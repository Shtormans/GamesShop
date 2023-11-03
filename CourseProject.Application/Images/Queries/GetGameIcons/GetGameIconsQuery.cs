using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.ValueObjects.Game;
using System.Drawing;

namespace CourseProject.Application.Images.Queries.GetGameIcons;

public sealed record GetGameIconsQuery(List<GameIcon> GameIcons) : IQuery<List<Image>>;
