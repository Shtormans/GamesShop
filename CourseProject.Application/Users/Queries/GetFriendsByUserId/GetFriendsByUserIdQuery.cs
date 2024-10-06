using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;

namespace CourseProject.Application.Users.Queries.GetFriendsByUserId;

public sealed record GetFriendsByUserIdQuery(Guid UserId) : IQuery<List<User>>;
