using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;

namespace CourseProject.Domain.ValueObjects.Identificators;

public sealed class UserId : ValueObject
{
    private UserId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; private set; }

    public static Result<UserId> Create(Guid id)
    {
        var userId = new UserId(id);

        return userId;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
