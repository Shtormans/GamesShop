using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;
using System;

namespace CourseProject.Domain.ValueObjects.User;

public sealed class UserBirthday : ValueObject
{
    [Newtonsoft.Json.JsonConstructor]
    private UserBirthday(DateTime date)
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

    public static Result<UserBirthday> Create(DateTime birthdayDate)
    {
        var dateInUTC = birthdayDate.ToUniversalTime();

        var date = new UserBirthday(dateInUTC);

        return date;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return DateInUTC;
    }
}
