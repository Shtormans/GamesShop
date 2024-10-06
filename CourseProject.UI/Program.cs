using CourseProject.Domain.Enums;
using CourseProject.Infrastructure;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using System.Resources;

namespace CourseProject.UI;

internal static class Program
{
    static async Task Main()
    {
        var host = CreateHostBuilder();

        ApplicationConfiguration.Initialize();

        host.Services.GetRequiredService<UIManager>();

        await host.Services.GetRequiredService<Startup>().Run();
    }

    private static IHost CreateHostBuilder()
    {
        var host = Host
            .CreateDefaultBuilder()
            .ConfigureServices((content, services) =>
            {
                ConfigureServices(content.Configuration, services);
            })
            .Build();

        return host;
    }

    private static void ConfigureServices(IConfiguration configurations, IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(
            dbContextOptionsBuilder =>
            {
                var connectionString = configurations.GetConnectionString("Database");

                dbContextOptionsBuilder.UseSqlServer(connectionString);
            });

        services
            .Scan(
            selector => selector
                .FromAssemblies(
                    Infrastructure.AssemblyReference.Assembly)
                .AddClasses(false)
                .AsImplementedInterfaces()
                .WithScopedLifetime());

        services
            .Scan(
            selector => selector
                .FromCallingAssembly()
                .AddClasses(classes => classes.AssignableTo<BaseController>())
                .AsSelf()
                .WithScopedLifetime());

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Application.AssemblyReference.Assembly));

        services
            .AddScoped<IMainForm, MainForm>()
            .AddScoped<UIManager>()
            .AddScoped<ControllersCollection>()
            .AddScoped(provider => new ControllersCollection(provider))
            .AddScoped<Startup>();

        CreateSession(configurations);

        ServiceRegistration.Register(services);
    }

    private static void CreateSession(IConfiguration configuration)
    {
        string languagePath = $"{configuration.GetConnectionString("LanguagesFolderPath")}.{configuration["Language"]}";

        ChangeSessionModel sessionModel = new()
        {
            User = null,
            Language = new ResourceManager(languagePath, Assembly.GetExecutingAssembly()),
            CurrencyType = (CurrencyType)Enum.Parse(typeof(CurrencyType), configuration["Currency"]!, true)
        };

        CurrentSessionController.SetNewSession(sessionModel);
    }
}