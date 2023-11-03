using CourseProject.Domain.Entities;

namespace CourseProject.Domain.Repositories;

public interface IGameRepository
{
    void Add(Game game);

    Task<Game?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<Game?> GetByTitleAsync(string title, CancellationToken cancellationToken = default);

    Task<List<Game>> GetByAuthorIdAsync(Guid authorId, CancellationToken cancellationToken = default);

    Task<List<Game>> GetByTitleAndSortModifier(
        string title,
        Func<Game, bool> where,
        Func<Game, object> orderBy,
        bool inAscendingOrder,
        int skip,
        int top,
        CancellationToken cancellationToken = default);

    public Task UpdateGame(Game oldGame, Game newGame, CancellationToken cancellationToken = default);
}
