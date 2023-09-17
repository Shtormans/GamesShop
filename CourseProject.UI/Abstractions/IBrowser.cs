using CourseProject.UI.Settings;

namespace CourseProject.UI.Abstractions;

internal interface IMainForm
{
    Task ShowView(BaseView view);
    Task ChangeSettings(BrowserSettings settings);
    Task WaitCursor(bool wait);
}
