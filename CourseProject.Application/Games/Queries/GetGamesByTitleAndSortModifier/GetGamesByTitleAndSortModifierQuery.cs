using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Enums;

namespace CourseProject.Application.Games.Queries.GetGamesByTitleAndSortModifier;

public sealed record GetGamesByTitleAndSortModifierQuery(string Title, SortGamesBy SortingStrategy, uint Skip, uint Top) : IQuery<List<Game>>;
