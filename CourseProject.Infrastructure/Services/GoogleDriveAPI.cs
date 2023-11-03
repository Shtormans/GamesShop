using CourseProject.Infrastructure.Abstractions;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Microsoft.Extensions.Configuration;

namespace CourseProject.Infrastructure.Services;

internal class GoogleDriveAPI : IWebStorage
{
    public const string ImageType = "jpeg";

    private readonly GoogleCredential _googleCredential;
    private readonly string _defaultPictureName;
    private readonly string _mainFolderPath;
    private readonly string _gameImagesFolderPath;
    private readonly string _profileImagesFolderPath;
    private readonly string _downloadedImagePath;
    private readonly string _gameImagesLocalPath;

    public GoogleDriveAPI(IConfiguration configuration)
    {
        _defaultPictureName = configuration.GetConnectionString("DefaultPictureName")!;
        _mainFolderPath = configuration.GetConnectionString("GoogleMainFolderPath")!;
        _gameImagesFolderPath = configuration.GetConnectionString("GoogleGameImages")!;
        _profileImagesFolderPath = configuration.GetConnectionString("GoogleUserImages")!;
        _downloadedImagePath = configuration.GetConnectionString("DownloadedImagePath")!;
        _gameImagesLocalPath = configuration.GetConnectionString("GameImages")!;

        var googleCredentialFilePath = configuration.GetConnectionString("GoogleCredentials")!;

        _googleCredential = GoogleCredential.FromFile(googleCredentialFilePath)
            .CreateScoped(new[] { DriveService.ScopeConstants.Drive });
    }

    public async Task DownloadDefaultPicture()
    {
        var service = new DriveService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = _googleCredential
        });

        var request = service.Files.List();
        request.Q = $"parents in '{_mainFolderPath}'";
        var response = await request.ExecuteAsync().ConfigureAwait(false);

        var downloadFile = response.Files.FirstOrDefault(file => file.Name == _defaultPictureName);
        if (downloadFile is not null)
        {
            var getRequest = service.Files.Get(downloadFile.Id);

            await using var fileStream = new FileStream(_downloadedImagePath, FileMode.Create, FileAccess.Write);
            await getRequest.DownloadAsync(fileStream).ConfigureAwait(false);
        }

        service.Dispose();
    }

    public async Task<bool> DownloadProfilePicture(string imageName)
    {
        using var service = new DriveService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = _googleCredential
        });

        var request = service.Files.List();
        request.Q = $"parents in '{_profileImagesFolderPath}'";
        var response = request.Execute();

        string name = $"{imageName}.{ImageType}";
        var downloadFile = response.Files.FirstOrDefault(file => file.Name == name);
        if (downloadFile is null)
        {
            return false;
        }

        var getRequest = service.Files.Get(downloadFile.Id);

        await using var fileStream = new FileStream(_downloadedImagePath, FileMode.Create, FileAccess.Write);
        getRequest.Download(fileStream);

        return true;
    }

    public async Task<bool> DownloadGameIcon(string imageName)
    {
        using var service = new DriveService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = _googleCredential
        });

        var request = service.Files.List();
        request.Q = $"parents in '{_gameImagesFolderPath}'";
        var response = request.Execute();

        string name = $"{imageName}.{ImageType}";
        var downloadFile = response.Files.FirstOrDefault(file => file.Name == name);
        if (downloadFile is null)
        {
            return false;
        }

        var getRequest = service.Files.Get(downloadFile.Id);

        await using var fileStream = new FileStream(_downloadedImagePath, FileMode.Create, FileAccess.Write);
        getRequest.Download(fileStream);

        return true;
    }

    public async Task UploadGameIcon(string imageName)
    {
        var service = new DriveService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = _googleCredential
        });

        string path = $"{Path.Combine(_gameImagesLocalPath, imageName)}.{ImageType}";
        var newFileBody = new Google.Apis.Drive.v3.Data.File()
        {
            Name = $"{imageName}.{ImageType}",
            Parents = new List<string>() { _gameImagesFolderPath }
        };

        await using (var uploadStream = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            var request = service.Files.Create(newFileBody, uploadStream, "image/jpeg");
            request.Fields = "*";
            var result = request.Upload();
        }

        service.Dispose();
    }
}
