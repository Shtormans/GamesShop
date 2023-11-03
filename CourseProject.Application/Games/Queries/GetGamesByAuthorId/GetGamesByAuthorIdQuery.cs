using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.ValueObjects.Identificators;

namespace CourseProject.Application.Games.Queries.GetGamesByAuthorId;

public sealed record GetGamesByAuthorIdQuery(Guid AuthorId) : IQuery<List<Game>>;
