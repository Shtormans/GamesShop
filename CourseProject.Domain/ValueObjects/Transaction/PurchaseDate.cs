using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;

namespace CourseProject.Domain.ValueObjects.Transaction;

public sealed class PurchaseDate : ValueObject
{
    private PurchaseDate(DateTime date)
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

    public static Result<PurchaseDate> Create(DateTime creationDate)
    {
        var dateInUTC = creationDate.ToUniversalTime();

        var date = new PurchaseDate(dateInUTC);

        return date;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return DateInUTC;
    }

    public static implicit operator DateTime(PurchaseDate gameCreationDate) => gameCreationDate.DateInUTC;
}
