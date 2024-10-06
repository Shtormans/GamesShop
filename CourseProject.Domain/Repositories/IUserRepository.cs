using CourseProject.Domain.Entities;

namespace CourseProject.Domain.Repositories;

public interface IUserRepository
{
    void Add(User user);

    public Task Update(User oldUser, User newUser, CancellationToken cancellationToken = default);

    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<User?> GetByIdWithTrackingAsync(Guid id, CancellationToken cancellationToken = default);

    Task<User?> GetByUsernameAsync(string username, CancellationToken cancellationToken = default);

    Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);

    Task<List<User>> GetFriendsByGameAsync(Guid userId, Guid gameId, CancellationToken cancellationToken = default);

    Task<List<User>> GetFriendsByUserIdAsync(Guid userId, CancellationToken cancellationToken = default);

    Task<User?> GetByIdWithLibraryAsync(Guid userId, CancellationToken cancellationToken = default);

    Task<List<User>> GetUsersByUsernameAsync(string username, int skip, int take, CancellationToken cancellationToken = default);
}
