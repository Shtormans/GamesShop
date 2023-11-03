using CourseProject.UI.Settings;

namespace CourseProject.UI.Abstractions;

internal interface IMainForm
{
    Task ShowView(BaseView view);
    Task ChangeSettings(BrowserSettings settings);
    Task ShowErrorMessage(string message);
    Task WaitCursor(bool wait);
    Task<string?> OpenFileDialog(string filter);
}
