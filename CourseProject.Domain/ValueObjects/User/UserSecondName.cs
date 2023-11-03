using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;

namespace CourseProject.Domain.ValueObjects.User;

public sealed class UserSecondName : ValueObject
{
    public const int MaxLength = 15;

    [Newtonsoft.Json.JsonConstructor]
    private UserSecondName(string value)
    {
        Value = value;
    }

    public string Value { get; private set; }

    public static Result<UserSecondName> Create(string secondName)
    {
        if (string.IsNullOrWhiteSpace(secondName))
        {
            return Result.Failure<UserSecondName>(new Error(
                "UserSecondName.Empty",
                "Second name is empty."));
        }

        if (secondName.Length > MaxLength)
        {
            return Result.Failure<UserSecondName>(new Error(
                "UserSecondName.TooLong",
                $"Second name must be maximum {MaxLength} characters long."));
        }

        return new UserSecondName(secondName);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
