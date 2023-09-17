using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;

namespace CourseProject.Domain.ValueObjects.User;

public sealed class UserPassword : ValueObject
{
    public const int MaxLength = 20;

    private UserPassword(string value)
    {
        Value = value;
    }

    public string Value { get; private set; }

    public static Result<UserPassword> Create(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
        {
            return Result.Failure<UserPassword>(new Error(
                "UserPassword.Empty",
                "Password is empty."));
        }

        if (password.Length > MaxLength)
        {
            return Result.Failure<UserPassword>(new Error(
                "UserPassword.TooLong",
                $"Password must be maximum {MaxLength} characters long."));
        }

        return new UserPassword(password);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
