using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;

namespace CourseProject.Domain.ValueObjects.User;

public sealed class UserFirstName : ValueObject
{
    public const int MaxLength = 15;

    [Newtonsoft.Json.JsonConstructor]
    private UserFirstName(string value)
    {
        Value = value;
    }

    public string Value { get; private set; }

    public static Result<UserFirstName> Create(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            return Result.Failure<UserFirstName>(new Error(
                "UserFirstName.Empty",
                "First name is empty."));
        }

        if (firstName.Length > MaxLength)
        {
            return Result.Failure<UserFirstName>(new Error(
                "UserFirstName.TooLong",
                $"First name must be maximum {MaxLength} characters long."));
        }

        return new UserFirstName(firstName);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
