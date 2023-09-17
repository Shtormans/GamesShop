using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;

namespace CourseProject.Domain.ValueObjects.Identificators;

public sealed class CommentId : ValueObject
{
    private CommentId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; private set; }

    public static Result<CommentId> Create(Guid id)
    {
        var commentId = new CommentId(id);

        return commentId;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
