using CourseProject.UI.Models;
using MediatR;

namespace CourseProject.UI.Abstractions;

internal abstract class BaseController
{
    protected readonly ISender Sender;
    protected readonly dynamic ViewBag;

    protected BaseController(ISender sender, ViewBag viewBag)
    {
        Sender = sender;
        ViewBag = viewBag;
    }
}
