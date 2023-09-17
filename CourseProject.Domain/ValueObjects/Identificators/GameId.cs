using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;

namespace CourseProject.Domain.ValueObjects.Identificators;

public sealed class GameId : ValueObject
{
    private GameId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; private set; }

    public static Result<GameId> Create(Guid id)
    {
        var gameId = new GameId(id);

        return gameId;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Value;
    }
}