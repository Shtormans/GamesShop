using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;

namespace CourseProject.Application.Transactions.Queries.GetTransactionsByGameCreatorWithGames;

public sealed record GetTransactionsByGameCreatorWithGamesQuery(Guid UserId, DateTime FromDate, DateTime ToDate) : IQuery<List<Transaction>>;
