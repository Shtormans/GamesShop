using System.Drawing;

namespace CourseProject.Domain.Repositories;

public interface IImageRepository
{
    Task<Image> GetGameImage(Guid imageId);

    Task<Image> GetUserImage(Guid imageId);
}
