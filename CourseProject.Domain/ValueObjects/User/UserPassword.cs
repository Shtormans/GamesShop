using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;

namespace CourseProject.Domain.ValueObjects.User;

public sealed class UserPassword : ValueObject
{
    public const int MaxLength = 20;
    private const string Key = "jvwML7dcEak7";

    [Newtonsoft.Json.JsonConstructor]
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

        return new UserPassword(Encrypt(password));
    }

    public static Result<UserPassword> CreateWithoutEncryption(string password)
    {
        var userResult = Create(password);
        userResult.Value.Value = Encrypt(userResult.Value.Value);

        return userResult;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }

    private static string Encrypt(string password)
    {
        char[] encryptedArray = password.ToCharArray();
        int numKey = Key.Sum(x => (int)x);

        for (int i = 0; i < password.Length; i++)
        {
            encryptedArray[i] ^= (char)numKey;
        }

        return new string(encryptedArray);
    }
}
