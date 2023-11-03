using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;

namespace CourseProject.Application.Comments.Queries.GetCommentsByGame;

public sealed record GetCommentsByGameQuery(Guid GameId, uint Take, uint Skip) : IQuery<List<Comment>>;
