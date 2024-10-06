using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Enums;
using System.Drawing;

namespace CourseProject.Application.Games.Commands.ChangeGame;

public sealed record ChangeGameCommand(Guid GameId, string Title, GameGenre Genre, string Description, Money Price, Image Icon) : ICommand;
