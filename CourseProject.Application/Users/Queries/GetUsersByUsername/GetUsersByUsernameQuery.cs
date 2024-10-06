using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;

namespace CourseProject.Application.Users.Queries.GetUsersByUsername;

public sealed record GetUsersByUsernameQuery(string Username, uint Skip, uint Take) : IQuery<List<User>>;
