using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;

namespace CourseProject.Application.Games.Queries.GetGamesByUserLibrary;

public sealed record GetGamesByUserLibraryQuery(Guid UserId) : IQuery<List<Game>>;
