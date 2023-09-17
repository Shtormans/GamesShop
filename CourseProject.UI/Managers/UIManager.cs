using CourseProject.UI.Abstractions;
using CourseProject.UI.Settings;
using System.Reflection;

namespace CourseProject.UI.Managers;

internal sealed class UIManager
{
    private static UIManager? _instance;

    private readonly IMainForm _browser;
    private readonly ControllersCollection _controllers;

    public UIManager(IMainForm browser, ControllersCollection controllers)
    {
        _browser = browser;
        _controllers = controllers;

        _instance = this;
    }

    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                throw new NotImplementedException();
            }

            return _instance;
        }
    }

    public async Task ShowView(string controllerName, string methodName = "Index", object?[]? parameters = null)
    {
        _browser.WaitCursor(true).Start();

        object? result = await UseMethodAsync(controllerName, methodName, parameters);

        var view = (BaseView)result!;

        await _browser.ShowView(view);

        _browser.WaitCursor(false).Start();
    }

    public async Task<object?> UseMethodAsync(string controllerName, string methodName, object?[]? parameters = null)
    {
        var controller = _controllers[controllerName];

        Type controllerType = controller.GetType();
        MethodInfo methodInfo = controllerType.GetMethod(methodName)!;

        dynamic task = methodInfo.Invoke(controller, parameters)!;
        object? result = await task;

        return result;
    }

    public async Task ChangeUISettings(BrowserSettings settings)
    {
        await _browser.ChangeSettings(settings);
    }
}
