using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;

namespace CourseProject.Domain.ValueObjects.Comment;

public sealed class CommentText : ValueObject
{
    private CommentText(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static Result<CommentText> Create(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return Result.Failure<CommentText>(new Error(
                "CommentText.Empty",
                "Comment text is empty."));
        }

        return new CommentText(text);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
