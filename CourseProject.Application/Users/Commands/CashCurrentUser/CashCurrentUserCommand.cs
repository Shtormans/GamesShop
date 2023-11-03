using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;

namespace CourseProject.Application.Users.Commands.CashCurrentUser;

public sealed record CashCurrentUserCommand(User User) : ICommand;
