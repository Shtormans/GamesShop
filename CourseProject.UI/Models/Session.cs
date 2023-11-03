using CourseProject.Domain.Entities;

namespace CourseProject.UI.Models;

internal class Session
{
	public Session(User currentUser)
	{
		CurrentUser = currentUser;
	}

    public User CurrentUser { get; private set; }
}
