using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;

namespace CourseProject.Domain.ValueObjects.User;

public sealed class UserProfilePicture : ValueObject
{

    [Newtonsoft.Json.JsonConstructor]
    private UserProfilePicture(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }

    public static Result<UserProfilePicture> Create(Guid id)
    {
        var image = new UserProfilePicture(id);

        return image;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Id;
    }
}
