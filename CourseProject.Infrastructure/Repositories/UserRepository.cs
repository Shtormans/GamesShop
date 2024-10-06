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

    public async Task Update(User oldUser, User newUser, CancellationToken cancellationToken = default)
    {
        string? firstName = newUser.FirstName is null ? null : newUser.FirstName.Value;
        string? secondName = newUser.SecondName is null ? null : newUser.SecondName.Value;

        await _dbContext
            .Database
            .ExecuteSqlAsync($"UPDATE [u] SET [u].[Username] = {newUser.Username.Value}, [u].[Email] = {newUser.Email.Value}, [u].[Birthday] = {newUser.Birthday.DateInUTC}, [u].[FirstName] = {firstName}, [u].[SecondName] = {secondName} FROM [Users] AS [u] WHERE [u].[Id] = {oldUser.Id}",
            cancellationToken);
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

    public async Task<User?> GetByIdWithTrackingAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Set<User>()
            .FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
    }

    public async Task<User?> GetByUsernameAsync(string username, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Set<User>()
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Username == username, cancellationToken);
    }

    public async Task<List<User>> GetFriendsByGameAsync(Guid userId, Guid gameId, CancellationToken cancellationToken = default)
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

    public async Task<List<User>> GetFriendsByUserIdAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        var userFriends = await _dbContext
            .Set<User>()
            .AsNoTracking()
            .Where(user => user.Id == userId)
        .SelectMany(user => user.Friends)
            .ToListAsync();

        var friends = await _dbContext
            .Set<User>()
            .AsNoTracking()
            .Where(user => user.Friends.Any(friend => friend.Id == userId))
            .ToListAsync();

        return userFriends.Concat(friends).ToList();
    }

    public async Task<List<User>> GetUsersByUsernameAsync(string username, int skip, int take, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Set<User>()
            .AsNoTracking()
            .Where(user => EF.Functions.Like(((string)user.Username).ToLower(), $"{username.ToLower()}%"))
            .Skip(skip)
            .Take(take)
            .OrderBy(user => user.Username)
            .ToListAsync();
    }
}
