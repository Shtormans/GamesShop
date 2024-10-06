using CourseProject.Domain.Entities;
using System.Drawing;

namespace CourseProject.Domain.Repositories;

public interface ICashRepository
{
    Task CashUser(User user);

    Task DeleteCashedUser();

    Task<User?> GetUser();

    Task<Image> GetProfilePicture(string name);

    Task<Image> GetGameIcon(string name);

    Task<Image> GetDefaultPicture();

    Task UploadGameIcon(string iconName, Image icon);

    Task UploadProfilePicture(string pictureName, Image picture);
}
