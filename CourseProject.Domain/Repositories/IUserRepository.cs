using CourseProject.Domain.Entities;

namespace CourseProject.Domain.Repositories;

public interface IUserRepository
{
    void Add(User user);

    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<User?> GetByUsernameAsync(string username, CancellationToken cancellationToken = default);

    Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);

    Task<List<User>> GetFriendsByGame(Guid userId, Guid gameId, CancellationToken cancellationToken = default);

    public Task<User?> GetByIdWithLibraryAsync(Guid userId, CancellationToken cancellationToken = default);
}
