using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;

namespace CourseProject.Application.Users.Queries.GetUserByEmailOrUsername;

public sealed record GetUserByEmailOrUsernameQuery(string EmailOrUsername) : IQuery<User>;
