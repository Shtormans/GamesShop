using CourseProject.Domain.Entities;
using CourseProject.Domain.Repositories;
using CourseProject.Infrastructure.Abstractions;
using CourseProject.Infrastructure.Services;
using System.Drawing;

namespace CourseProject.Infrastructure.Repositories;

internal class CashRepository : ICashRepository
{
    private readonly ILocalStorage _localStorage;
    private readonly IWebStorage _webStorage;

    public CashRepository(ILocalStorage localStorage, IWebStorage webStorage)
    {
        _localStorage = localStorage;
        _webStorage = webStorage;
    }

    public async Task CashUser(User user)
    {
        string json = JsonConverter.SerializeResponse(user);

        await _localStorage.WriteToCurrentUserFile(json);
    }

    public async Task<User?> GetUser()
    {
        bool fileExist = await _localStorage.CurrentUserFileEmptyOrDoNotExist();
        if (!fileExist)
        {
            return null;
        }

        string json = await _localStorage.ReadFromCurrentUserFile();

        User? user = JsonConverter.DeserializeResponse<User?>(json);

        return user;
    }

    public async Task<Image> GetProfilePicture(string name)
    {
        Image? image = await _localStorage.GetProfilePicture(name);
        if (image is not null)
        {
            return image;
        }

        var imageExist = await _webStorage.DownloadProfilePicture(name).ConfigureAwait(false);
        if (imageExist)
        {
            await _localStorage.SaveDownloadedProfilePicture(name);

            return (await _localStorage.GetProfilePicture(name))!;
        }
        else
        {
            return await GetDefaultPicture();
        }
    }

    public async Task<Image> GetGameIcon(string name)
    {
        Image? image = await _localStorage.GetGameIcon(name);
        if (image is not null)
        {
            return image;
        }

        var imageExist = await _webStorage.DownloadGameIcon(name).ConfigureAwait(false);
        if (imageExist)
        {
            await _localStorage.SaveDownloadedGameIcon(name);

            return (await _localStorage.GetGameIcon(name))!;
        }
        else
        {
            return await GetDefaultPicture();
        }
    }

    public async Task<Image> GetDefaultPicture()
    {
        Image? image = await _localStorage.GetDefaultImage();
        if (image == null)
        {
            await _webStorage.DownloadDefaultPicture();
            await _localStorage.SaveDefaultImage();

            return (await _localStorage.GetDefaultImage())!;
        }

        return image;
    }

    public async Task UploadGameIcon(string iconName, Image icon)
    {
        await _localStorage.UploadGameIcon(iconName, icon);
        await _webStorage.UploadGameIcon(iconName);
    }
}
