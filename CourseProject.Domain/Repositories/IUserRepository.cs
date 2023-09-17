using CourseProject.Domain.Entities;

namespace CourseProject.Domain.Repositories;

public interface IUserRepository
{
    void Add(User user);

    Task<User> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
