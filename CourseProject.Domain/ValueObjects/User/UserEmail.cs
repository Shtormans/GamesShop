using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;
using System.Text.RegularExpressions;

namespace CourseProject.Domain.ValueObjects.User;

public sealed class UserEmail : ValueObject
{
    public const int MaxLength = 255;

    [Newtonsoft.Json.JsonConstructor]
    private UserEmail(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static Result<UserEmail> Create(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return Result.Failure<UserEmail>(new Error(
                "UserEmail.Empty",
                "Email is empty."));
        }

        if (email.Length > MaxLength)
        {
            return Result.Failure<UserEmail>(new Error(
                "UserEmail.TooLong",
                $"Email must be maximum {MaxLength} characters long."));
        }

        if (!Regex.IsMatch(email, @"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$"))
        {
            return Result.Failure<UserEmail>(new Error(
                "UserEmail.WrongFormat",
                "Email has a wrong format."));
        }

        return new UserEmail(email);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }

    public static implicit operator string(UserEmail userEmail) => userEmail.Value;
}
