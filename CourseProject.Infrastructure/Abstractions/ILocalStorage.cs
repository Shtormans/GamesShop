using System.Drawing;

namespace CourseProject.Infrastructure.Abstractions;

internal interface ILocalStorage
{
    Task<bool> CurrentUserFileEmptyOrDoNotExist();

    Task<string> ReadFromCurrentUserFile();

    Task WriteToCurrentUserFile(string text);

    Task SaveDownloadedProfilePicture(string name);

    Task<Image?> GetProfilePicture(string name);

    Task SaveDownloadedGameIcon(string name);

    Task<Image?> GetGameIcon(string name);

    Task SaveDefaultImage();

    Task<Image?> GetDefaultImage();

    Task UploadGameIcon(string name, Image icon);
}
