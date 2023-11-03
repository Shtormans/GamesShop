using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;

namespace CourseProject.Application.Users.Queries.GetUsersByIds;

public sealed record GetUsersByIdQuery(Guid UserId) : IQuery<User>;
