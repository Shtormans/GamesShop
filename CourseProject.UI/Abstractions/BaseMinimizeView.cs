using CourseProject.UI.Models;

namespace CourseProject.UI.Abstractions;

internal abstract class BaseMinimizeView : BaseView
{
	public BaseMinimizeView(ViewBag viewbag)
        : base(viewbag)

    {
        this.Dock = DockStyle.Fill;
    }

    public void Destroy()
    {
        this.Controls.Clear();
    }
}
