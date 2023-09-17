using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;
using System.Drawing;

namespace CourseProject.Domain.ValueObjects.Game;

public sealed class GameImage : ValueObject
{
    private GameImage(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; }
    public Bitmap Image
    {
        get
        {
            return null;
        }
    }

    public static Result<GameImage> Create(Guid id)
    {
        var image = new GameImage(id);

        return image;
    }

    public override IEnumerable<object> GetAtomicValues()
    {
        yield return Id;
    }
}
