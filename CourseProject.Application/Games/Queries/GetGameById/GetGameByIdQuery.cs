using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.ValueObjects.Identificators;

namespace CourseProject.Application.Games.Queries.GetGameById;

public sealed record GetGameByIdQuery(GameId GameId) : IQuery<Game>;
