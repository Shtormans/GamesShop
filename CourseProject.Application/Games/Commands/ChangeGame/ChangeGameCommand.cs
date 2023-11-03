using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using System.Drawing;

namespace CourseProject.Application.Games.Commands.ChangeGame;

public sealed record ChangeGameCommand(Guid GameId, string Title, string Description, Money Price, Image Icon) : ICommand;
