using CourseProject.Domain.Entities;
using CourseProject.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace CourseProject.Infrastructure.Repositories;

internal class GameRepository : IGameRepository
{
    private readonly ApplicationDbContext _dbContext;

    public GameRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(Game game)
    {
        _dbContext.Games.Add(game);
    }

    public async Task<List<Game>> GetByAuthorIdAsync(Guid authorId, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Set<Game>()
            .AsNoTracking()
            .Where(g => g.AuthorId == authorId)
            .ToListAsync();
    }

    public async Task<Game?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Set<Game>()
            .AsNoTracking()
            .FirstOrDefaultAsync(g => g.Id == id, cancellationToken);
    }

    public async Task<Game?> GetByTitleAsync(string title, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Set<Game>()
            .AsNoTracking()
            .FirstOrDefaultAsync(g => g.Title == title, cancellationToken);
    }

    public async Task UpdateGame(Game oldGame, Game newGame, CancellationToken cancellationToken = default)
    {
        await _dbContext
            .Database
            .ExecuteSqlAsync($"UPDATE [g] SET [g].[Description] = {newGame.Description.Value}, [g].[Title] = {newGame.Title.Value}, [g].[Price_Currency] = {newGame.Price.Currency}, [g].[Price_Amount] = {newGame.Price.Amount} FROM [Games] AS [g] WHERE [g].[Id] = {oldGame.Id}",
            cancellationToken);
    }

    public async Task<List<Game>> GetByTitleAndSortModifier(
            string title,
            Func<Game, bool> where,
            Func<Game, object> orderBy,
            bool inAscendingOrder,
            int skip,
            int top,
            CancellationToken cancellationToken = default)
    {
        var query = _dbContext
            .Set<Game>()
            .AsNoTracking()
            .Where(where);

        IOrderedEnumerable<Game> orderedQuery;
        if (inAscendingOrder)
        {
            orderedQuery = query.OrderBy(orderBy);
        }
        else
        {
            orderedQuery = query.OrderByDescending(orderBy);
        }

        return orderedQuery
                .Skip(skip)
                .Take(top)
                .ToList();
    }
}
