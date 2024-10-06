using CourseProject.Domain.Entities;
using CourseProject.Domain.Enums;

namespace CourseProject.Domain.Repositories;

public interface IGameRepository
{
    void Add(Game game);

    public Task Update(Game oldGame, Game newGame, CancellationToken cancellationToken = default);

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
        List<GameGenre> genres,
        CancellationToken cancellationToken = default);
}
