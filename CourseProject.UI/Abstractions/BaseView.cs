using CourseProject.UI.Models;

namespace CourseProject.UI.Abstractions;

internal abstract class BaseView : GroupBox
{
    protected readonly dynamic ViewBag;

    public BaseView(ViewBag viewBag)
    {
        ViewBag = viewBag;

        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Dock = DockStyle.Fill;
    }
}
