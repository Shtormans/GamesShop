namespace CourseProject.Infrastructure.Abstractions;

internal interface IWebStorage
{
    Task DownloadDefaultPicture();

    Task<bool> DownloadProfilePicture(string imageName);

    Task<bool> DownloadGameIcon(string imageName);

    Task UploadGameIcon(string imageName);

    Task UploadProfilePicture(string imageName);
}
