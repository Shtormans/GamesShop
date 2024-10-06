using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Enums;
using CourseProject.Domain.ValueObjects.Identificators;
using System.Drawing;

namespace CourseProject.Application.Games.Commands.PublishGame;

public sealed record PublishGameCommand(string Title, DateTime CreationDate, Money Price, GameGenre Genre, UserId AuthorId, string Description, Image Icon) : ICommand;
