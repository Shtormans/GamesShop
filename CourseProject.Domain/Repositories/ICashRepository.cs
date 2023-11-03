using CourseProject.Domain.Entities;
using System.Drawing;

namespace CourseProject.Domain.Repositories;

public interface ICashRepository
{
    Task CashUser(User user);

    Task<User?> GetUser();

    Task<Image> GetProfilePicture(string name);

    Task<Image> GetGameIcon(string name);

    Task<Image> GetDefaultPicture();

    Task UploadGameIcon(string iconName, Image icon);
}
