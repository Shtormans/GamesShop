using CourseProject.Domain.Entities;
using CourseProject.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Infrastructure.Repositories;

internal class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _dbContext;

    public UserRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(User user)
    {
        _dbContext.Users.Add(user);
    }

    public async Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Set<User>()
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Email == email, cancellationToken);
    }

    public async Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Set<User>()
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
    }

    public async Task<User?> GetByUsernameAsync(string username, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Set<User>()
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Username == username, cancellationToken);
    }

    public async Task<List<User>> GetFriendsByGame(Guid userId, Guid gameId, CancellationToken cancellationToken = default)
    {
        var userFriends = await _dbContext
            .Set<User>()
            .AsNoTracking()
            .Where(user => user.Id == userId)
            .SelectMany(user => user.Friends)
            .Where(user => user.Library.Any(game => game.Id == gameId))
            .ToListAsync();

        var friendsPlayingGame = await _dbContext
            .Set<User>()
            .AsNoTracking()
            .Where(user => user.Friends.Any(friend => friend.Id == userId))
            .Where(user => user.Library.Any(game => game.Id == gameId))
            .ToListAsync();

        return userFriends.Concat(friendsPlayingGame).ToList();
    }

    public async Task<User?> GetByIdWithLibraryAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Set<User>()
            .AsNoTracking()
            .Include(user => user.Library)
            .Where(user => user.Id == userId)
            .FirstOrDefaultAsync();
    }
}
