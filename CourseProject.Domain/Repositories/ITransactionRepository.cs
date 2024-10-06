using CourseProject.Domain.Entities;

namespace CourseProject.Domain.Repositories;

public interface ITransactionRepository
{
    void Add(Transaction transaction);

    Task<List<Transaction>> GetByGameCreatorWithGamesAsync(Guid userId, DateTime fromDate, DateTime toDate, CancellationToken cancellationToken = default);
}
