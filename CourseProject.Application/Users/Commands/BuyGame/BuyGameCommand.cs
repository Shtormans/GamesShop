using CourseProject.Application.Abstractions.Messaging;

namespace CourseProject.Application.Users.Commands.BuyGame;

public sealed record BuyGameCommand(Guid PayerId, Guid ReceiverId, Money Price, Guid GameId) : ICommand;
