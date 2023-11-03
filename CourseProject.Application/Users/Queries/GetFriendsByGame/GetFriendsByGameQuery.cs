using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;

namespace CourseProject.Application.Users.Queries.GetFriendsByGame;

public sealed record GetFriendsByGameQuery(Guid UserId, Guid GameId) : IQuery<List<User>>;
