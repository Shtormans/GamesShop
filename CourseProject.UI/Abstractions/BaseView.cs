using CourseProject.UI.Models;

namespace CourseProject.UI.Abstractions;

internal abstract class BaseView : Panel
{
    protected readonly dynamic ViewBag;

    public BaseView(ViewBag viewBag)
    {
        ViewBag = viewBag;

        InitializeComponent();
    }

    protected abstract void InitializeComponent();
}
