using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;

namespace CourseProject.Domain.ValueObjects.Game;

public sealed class GameIcon : ValueObject
{
    private GameIcon(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }

    public static Result<GameIcon> Create(Guid id)
    {
        var image = new GameIcon(id);

        return image;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Id;
    }
}
