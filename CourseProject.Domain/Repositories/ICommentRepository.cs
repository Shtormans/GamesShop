using CourseProject.Domain.Entities;

namespace CourseProject.Domain.Repositories;

public interface ICommentRepository
{
    void Add(Comment comment);

    Task<Comment> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
