using CourseProject.Domain.Entities;

namespace CourseProject.Domain.Repositories;

public interface ICommentRepository
{
    void Add(Comment comment);

    Task<Comment> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<List<Comment>> GetByGameIdAsync(Guid gameId, int top, int skip = 0, CancellationToken cancellationToken = default);
}
