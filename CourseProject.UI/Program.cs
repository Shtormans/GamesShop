using CourseProject.Infrastructure;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CourseProject.UI;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        var host = CreateHostBuilder();

        ApplicationConfiguration.Initialize();
        System.Windows.Forms.Application.Run(host.Services.GetRequiredService<IMainForm>() as Form);
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
                .WithSingletonLifetime());

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Application.AssemblyReference.Assembly));

        services
            .AddScoped<ViewBag>()
            .AddSingleton<IMainForm, MainForm>()
            .AddSingleton<UIManager>()
            .AddSingleton(provider => new ControllersCollection(provider));
    }
}