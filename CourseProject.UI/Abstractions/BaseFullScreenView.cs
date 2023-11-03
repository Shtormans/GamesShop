using CourseProject.UI.Models;

namespace CourseProject.UI.Abstractions;

internal abstract class BaseFullScreenView : BaseView
{
	public BaseFullScreenView(ViewBag viewbag)
        : base(viewbag)
	{
        this.Dock = DockStyle.Fill;
    }
}
