using CourseProject.Domain.Entities;

namespace CourseProject.Domain.Repositories;

public interface IGameRepository
{
    void Add(Game game);

    Task<Game> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
