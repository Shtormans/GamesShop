using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;

namespace CourseProject.Domain.ValueObjects.User;

public sealed class Username : ValueObject
{
    public const int MaxLength = 15;

    [Newtonsoft.Json.JsonConstructor]
    private Username(string value)
    {
        Value = value;
    }

    public string Value { get; private set; }

    public static Result<Username> Create(string username)
    {
        if (string.IsNullOrWhiteSpace(username))
        {
            return Result.Failure<Username>(new Error(
                "Username.Empty",
                "Username is empty."));
        }

        if (username.Length > MaxLength)
        {
            return Result.Failure<Username>(new Error(
                "Username.TooLong",
                $"Username must be maximum {MaxLength} characters long."));
        }

        return new Username(username);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }

    public static implicit operator string(Username username) => username.Value;
}
