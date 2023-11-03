using CourseProject.Domain.Entities;

namespace CourseProject.UI.Models;

internal class UserWithProfilePicture
{
    public User User { get; set; }
    public Image ProfilePicture { get; set; }
}
