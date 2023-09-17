using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;

namespace CourseProject.Domain.ValueObjects.Comment;

public sealed class CommentCreationDate : ValueObject
{
    private CommentCreationDate(DateTime date)
    {
        DateInUTC = date;
    }

    public DateTime DateInUTC { get; }

    public DateTime DateInLocalTimeZone
    {
        get
        {
            return DateInUTC.ToLocalTime();
        }
    }

    public static Result<CommentCreationDate> Create(DateTime creationDate)
    {
        var dateInUTC = creationDate.ToUniversalTime();

        var date = new CommentCreationDate(dateInUTC);

        return date;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return DateInUTC;
    }
}
