using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.ValueObjects.Game;
using CourseProject.Domain.ValueObjects.Identificators;

namespace CourseProject.Application.Games.Commands.PublishGame;

public sealed record PublishGameCommand(string Title, Money Price, UserId AuthorId, string Description, GameImage ImageId) : ICommand<GameId>;
