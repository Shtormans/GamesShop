using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;
using System;

namespace CourseProject.Domain.ValueObjects.Game;

public sealed class GameCreationDate : ValueObject
{
    private GameCreationDate(DateTime date)
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

    public static Result<GameCreationDate> Create(DateTime birthdayDate)
    {
        var dateInUTC = birthdayDate.ToUniversalTime();

        var date = new GameCreationDate(dateInUTC);

        return date;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return DateInUTC;
    }

    public static implicit operator DateTime(GameCreationDate gameCreationDate) => gameCreationDate.DateInUTC;
}
