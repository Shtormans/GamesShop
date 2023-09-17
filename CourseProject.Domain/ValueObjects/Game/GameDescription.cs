using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;

namespace CourseProject.Domain.ValueObjects.Game;

public sealed class GameDescription : ValueObject
{
    private GameDescription(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static Result<GameDescription> Create(string description)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            return Result.Failure<GameDescription>(new Error(
                "GameDescription.Empty",
                "Game description is empty."));
        }

        return new GameDescription(description);
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}
