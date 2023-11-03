using CourseProject.Domain.Entities;
using CourseProject.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Infrastructure.Repositories;

internal class CommentRepository : ICommentRepository
{
    private readonly ApplicationDbContext _dbContext;

    public CommentRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(Comment comment)
    {
        _dbContext.Comments.Add(comment);
    }

    public async Task<Comment> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<List<Comment>> GetByGameIdAsync(Guid gameId, int top, int skip = 0, CancellationToken cancellationToken = default)
    {
        return await _dbContext
            .Set<Comment>()
            .AsNoTracking()
            .Where(comment => comment.GameId == gameId)
            .OrderByDescending(comment => (DateTime)comment.CreationDate)
            .Skip(skip) 
            .Take(top) 
            .ToListAsync(cancellationToken);
    }
}
