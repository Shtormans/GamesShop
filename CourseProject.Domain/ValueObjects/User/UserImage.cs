using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;
using System.Drawing;

namespace CourseProject.Domain.ValueObjects.User;

public sealed class UserImage : ValueObject
{
    private UserImage(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
    public Bitmap Image
    {
        get
        {
            return null;
        }
    }

    public static Result<UserImage> Create(Guid id)
    {
        var image = new UserImage(id);

        return image;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Id;
    }
}
