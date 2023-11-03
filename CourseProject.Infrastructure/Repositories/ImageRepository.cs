using CourseProject.Domain.Repositories;
using System.Drawing;

namespace CourseProject.Infrastructure.Repositories;

internal class ImageRepository : IImageRepository
{
    public Task<Image> GetGameImage(Guid imageId)
    {
        throw new NotImplementedException();
    }

    public Task<Image> GetUserImage(Guid imageId)
    {
        throw new NotImplementedException();
    }
}
