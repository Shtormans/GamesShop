using CourseProject.Application.Users.Queries.GetCurrentUser;
using CourseProject.Domain.Entities;
using CourseProject.Infrastructure.Services;
using CourseProject.UI.Abstractions;
using CourseProject.UI.Controllers;
using CourseProject.UI.Managers;
using CourseProject.UI.Models;
using CourseProject.UI.Views.Registration;
using MediatR;
using Microsoft.Extensions.Hosting;

namespace CourseProject.UI;

internal class Startup
{
    private readonly IServiceProvider _services;
    private readonly IMainForm _form;
    private readonly ISender _sender;

    private bool _keepOpen = true;

    public Startup(IServiceProvider services, IMainForm form, ISender sender)
    {
        _services = services;
        _form = form;
        _sender = sender;
    }

    public async Task Run()
    {
        ((Form)_form).FormClosed += Startup_FormClosed;

        await StartForm();

        await ChooseView();


        while (_keepOpen)
        {

        }
    }

    private void Startup_FormClosed(object? sender, FormClosedEventArgs e)
    {
        _keepOpen = false;
    }

    private async Task StartForm()
    {
        Task task = new Task(() =>
        {
            System.Windows.Forms.Application.Run(_form as Form);
        });
        task.Start();
    }

    private async Task ChooseView()
    {
        var query = new GetCurrentUserQuery();

        var userResult = await _sender.Send(query);
        if (userResult.IsFailure)
        {
            await UIManager.Instance.ShowView(nameof(LoginController), "ShowLoginForm");
        }
        else
        {
            CurrentSessionController.SetNewSession(new ChangeSessionModel()
            {
                User = userResult.Value
            });
            await UIManager.Instance.ShowView(nameof(HomeController)).ConfigureAwait(false);
        }
    }
}
