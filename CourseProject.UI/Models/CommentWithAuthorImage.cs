using CourseProject.Domain.Entities;

namespace CourseProject.UI.Models;

internal class CommentWithAuthorImage
{
    public Comment Comment { get; set; }
    public User Author { get; set; }
    public Image AuthorPicture { get; set; }
}
