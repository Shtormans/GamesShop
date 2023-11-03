using CourseProject.Infrastructure.Abstractions;
using Microsoft.Extensions.Configuration;
using System.Drawing;
using System.Drawing.Imaging;

namespace CourseProject.Infrastructure.Services;

internal class LocalFilesStorage : ILocalStorage
{
    public const string ImageType = "jpeg";

    private readonly string _cashedFolderPath;
    private readonly string _currentProfileFilePath;
    private readonly string _gameImagesFolderPath;
    private readonly string _profileImagesFolderPath;
    private readonly string _defaultPictureName;
    private readonly string _downloadedImagePath;

    public LocalFilesStorage(IConfiguration configuration)
    {
        _cashedFolderPath = configuration.GetConnectionString("CashedFolderPath")!;
        _currentProfileFilePath = configuration.GetConnectionString("UserCashFile")!;
        _gameImagesFolderPath = configuration.GetConnectionString("GameImages")!;
        _profileImagesFolderPath = configuration.GetConnectionString("UserImages")!;
        _defaultPictureName = configuration.GetConnectionString("DefaultPictureName")!;
        _downloadedImagePath = configuration.GetConnectionString("DownloadedImagePath")!;

        CheckAllPaths();
    }

    private void CheckAllPaths()
    {
        if (!Directory.Exists(_cashedFolderPath))
        {
            Directory.CreateDirectory(_cashedFolderPath);
        }

        if (!Directory.Exists(_gameImagesFolderPath))
        {
            Directory.CreateDirectory(_gameImagesFolderPath);
        }

        if (!Directory.Exists(_profileImagesFolderPath))
        {
            Directory.CreateDirectory(_profileImagesFolderPath);
        }
    }

    public async Task<bool> CurrentUserFileEmptyOrDoNotExist()
    {
        bool fileExist = File.Exists(_currentProfileFilePath);

        if (fileExist)
        {
            var text = File.ReadAllText(_currentProfileFilePath);

            return text != string.Empty;
        }

        var file = File.Create(_currentProfileFilePath);
        file.Close();

        return false;
    }

    public async Task<string> ReadFromCurrentUserFile()
    {
        return File.ReadAllText(_currentProfileFilePath);
    }

    public async Task WriteToCurrentUserFile(string text)
    {
        await File.WriteAllTextAsync(_currentProfileFilePath, text);
    }

    public async Task SaveDownloadedProfilePicture(string name)
    {
        string newPath = $"{Path.Combine(_profileImagesFolderPath, name)}.{ImageType}";
        File.Move(_downloadedImagePath, newPath);
    }

    public async Task<Image?> GetProfilePicture(string name)
    {
        string path = $"{Path.Combine(_profileImagesFolderPath, name)}.{ImageType}";
        if (!File.Exists(path))
        {
            return null;
        }

        var bytes = File.ReadAllBytes(path);
        var memoryStream = new MemoryStream(bytes);
        var image = Image.FromStream(memoryStream);

        return image;
    }

    public async Task SaveDownloadedGameIcon(string name)
    {
        string newPath = $"{Path.Combine(_gameImagesFolderPath, name)}.{ImageType}";
        File.Move(_downloadedImagePath, newPath);
    }

    public async Task<Image?> GetGameIcon(string name)
    {
        string path = $"{Path.Combine(_gameImagesFolderPath, name)}.{ImageType}";
        if (!File.Exists(path))
        {
            return null;
        }

        var bytes = File.ReadAllBytes(path);
        var memoryStream = new MemoryStream(bytes);
        var image = Image.FromStream(memoryStream);

        return image;
    }

    public async Task SaveDefaultImage()
    {
        string newPath = $"{Path.Combine(_cashedFolderPath, _defaultPictureName)}";
        File.Move(_downloadedImagePath, newPath);
    }

    public async Task<Image?> GetDefaultImage()
    {
        string path = $"{Path.Combine(_cashedFolderPath, _defaultPictureName)}";
        if (!File.Exists(path))
        {
            return null;
        }

        var bytes = File.ReadAllBytes(path);
        var memoryStream = new MemoryStream(bytes);
        var image = Image.FromStream(memoryStream);

        return image;
    }

    public async Task UploadGameIcon(string name, Image icon)
    {
        string path = $"{Path.Combine(_gameImagesFolderPath, name)}.{ImageType}";
        if (File.Exists(path))
        {
            File.Delete(path);
        }

        icon.Save(path, ImageFormat.Jpeg);
    }
}
