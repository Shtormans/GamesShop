using CourseProject.Infrastructure.Abstractions;
using CourseProject.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CourseProject.Infrastructure;

public static class ServiceRegistration
{
    public static void Register(IServiceCollection services)
    {
        services
            .AddScoped<ILocalStorage, LocalFilesStorage>()
            .AddScoped<IWebStorage, GoogleDriveAPI>();
    }
}
