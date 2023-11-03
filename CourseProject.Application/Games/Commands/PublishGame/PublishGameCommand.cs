using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.ValueObjects.Game;
using CourseProject.Domain.ValueObjects.Identificators;
using System.Drawing;

namespace CourseProject.Application.Games.Commands.PublishGame;

public sealed record PublishGameCommand(string Title, DateTime CreationDate, Money Price, UserId AuthorId, string Description, Image Icon) : ICommand;
