using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;

namespace CourseProject.Domain.ValueObjects.Game;

public sealed class GameTitle : ValueObject
{
    public const int MaxLength = 20;

    private GameTitle(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static Result<GameTitle> Create(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            return Result.Failure<GameTitle>(new Error(
                "GameTitle.Empty",
                "Game title is empty."));
        }

        if (title.Length > MaxLength)
        {
            return Result.Failure<GameTitle>(new Error(
                "GameTitle.TooLong",
                $"Game title must be maximum {MaxLength} characters long."));
        }

        return new GameTitle(title);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }

    public static implicit operator string(GameTitle gameTitle) => gameTitle.Value;
}
