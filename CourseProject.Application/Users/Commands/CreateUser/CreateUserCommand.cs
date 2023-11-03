using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;

namespace CourseProject.Application.Users.Commands.CreateUser;

public sealed record CreateUserCommand(string Username, string Email, string Password, DateTime Birthday, string? FirstName = null, string? SecondName = null) : ICommand<User>;
