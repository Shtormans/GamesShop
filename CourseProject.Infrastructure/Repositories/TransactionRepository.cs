using CourseProject.Domain.Entities;
using CourseProject.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Infrastructure.Repositories;

internal class TransactionRepository : ITransactionRepository
{
    private readonly ApplicationDbContext _dbContext;

    public TransactionRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(Transaction transaction)
    {
        _dbContext.Transactions.Add(transaction);
    }

    public async Task<List<Transaction>> GetByGameCreatorWithGamesAsync(Guid userId, DateTime fromDate, DateTime toDate, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Set<Transaction>()
            .AsNoTracking()
            .Include(t => t.Game)
            .Where(t => t.Game.AuthorId == userId)
            .Where(t => t.PurchaseDate >= fromDate && t.PurchaseDate <= toDate)
            .ToListAsync();
    }
}
