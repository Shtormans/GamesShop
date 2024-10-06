using CourseProject.Application.Abstractions.Messaging;
using CourseProject.Domain.Entities;
using CourseProject.Domain.Errors;
using CourseProject.Domain.Repositories;
using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.Transaction;

namespace CourseProject.Application.Transactions.Queries.GetTransactionsByGameCreatorWithGames;

internal class GetTransactionsByGameCreatorWithGamesQueryHandler : IQueryHandler<GetTransactionsByGameCreatorWithGamesQuery, List<Transaction>>
{
    private readonly ITransactionRepository _transactionRepository;
    private readonly IUserRepository _userRepository;

    public GetTransactionsByGameCreatorWithGamesQueryHandler(ITransactionRepository transactionRepository, IUserRepository userRepository)
    {
        _transactionRepository = transactionRepository;
        _userRepository = userRepository;
    }

    public async Task<Result<List<Transaction>>> Handle(GetTransactionsByGameCreatorWithGamesQuery request, CancellationToken cancellationToken)
    {
        var fromDate = PurchaseDate.Create(request.FromDate);
        if (fromDate.IsFailure)
        {
            return Result.Failure<List<Transaction>>(fromDate.Error);
        }

        var toDate = PurchaseDate.Create(request.ToDate);
        if (toDate.IsFailure)
        {
            return Result.Failure<List<Transaction>>(toDate.Error);
        }

        var user = await _userRepository.GetByIdAsync(request.UserId);
        if (user is null)
        {
            return Result.Failure<List<Transaction>>(DomainErrors.User.WrongId);
        }

        var transaction = await _transactionRepository.GetByGameCreatorWithGamesAsync(user.Id, fromDate.Value, toDate.Value, cancellationToken);
        return transaction;
    }
}
