using CourseProject.UI.Abstractions;
using CourseProject.UI.Settings;
using System.Reflection;

namespace CourseProject.UI.Managers;

internal sealed class UIManager
{
    private static UIManager? _instance;

    private readonly IMainForm _mainForm;
    private readonly ControllersCollection _controllers;

    public UIManager(IMainForm browser, ControllersCollection controllers)
    {
        _mainForm = browser;
        _controllers = controllers;

        _instance = this;
    }

    public static UIManager Instance
    {
        get
        {
            if (_instance is null)
            {
                throw new NotImplementedException();
            }

            return _instance;
        }
    }

    public async Task ShowView(string controllerName, string methodName = "Index", object?[]? parameters = null)
    {
        await _mainForm.WaitCursor(true);

        object? result = await UseMethodAsync(controllerName, methodName, parameters);

        var view = (BaseView)result!;

        await _mainForm.ShowView(view);

        await _mainForm.WaitCursor(false);
    }

    public async Task<BaseView> GetView(string controllerName, string methodName = "Index", object?[]? parameters = null)
    {
        await _mainForm.WaitCursor(true);

        object? result = await UseMethodAsync(controllerName, methodName, parameters);

        var view = (BaseView)result!;

        await _mainForm.WaitCursor(false);

        return view;
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

    public async Task ShowErrorMessage(string message)
    {
        await _mainForm.ShowErrorMessage(message);
    }

    public async Task ChangeUISettings(BrowserSettings settings)
    {
        await _mainForm.ChangeSettings(settings);
    }

    public async Task<string?> OpenFileDialog(string filter)
    {
        return await _mainForm.OpenFileDialog(filter);
    }
}
