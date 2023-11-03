using CourseProject.UI.Abstractions;

namespace CourseProject.UI.Views;

internal class ChangeableMinimizeView : Panel
{
    private BaseMinimizeView _minimizeView;

    public ChangeableMinimizeView()
    {
        this.Dock = DockStyle.Fill;
    }

    public void SetView(BaseMinimizeView minimizeView)
    {
        if (_minimizeView is not null)
        {
            _minimizeView.Destroy();
            this.Controls.Clear();
        }

        _minimizeView = minimizeView;
        this.Controls.Add(minimizeView);
    }

    public Type GetViewType() => _minimizeView.GetType();
}
