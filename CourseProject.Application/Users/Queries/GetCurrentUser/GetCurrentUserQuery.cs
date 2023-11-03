using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;

namespace CourseProject.Application.Users.Queries.GetCurrentUser;

public sealed record GetCurrentUserQuery : IQuery<User>;
