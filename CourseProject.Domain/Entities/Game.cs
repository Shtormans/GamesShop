using CourseProject.Domain.Primitives;
using CourseProject.Domain.ValueObjects.Game;
using CourseProject.Domain.ValueObjects.Identificators;

namespace CourseProject.Domain.Entities;

public sealed class Game : Entity
{
    public Game(Guid id)
        : base(id)
    {
    }

    public GameTitle Title { get; private set; }
    public Money Price { get; private set; }
    public Guid AuthorId { get; private set; }
    public GameDescription Description { get; private set; }
    public GameImage Image { get; private set; }
    public List<Comment> Comments { get; private set; }

    public static Game Create(GameTitle title, Money price, UserId authorId, GameDescription description, GameImage image)
    {
        Guid id = Guid.NewGuid();

        var game = new Game(id)
        {
            Title = title,
            Price = price,
            AuthorId = authorId.Value,
            Description = description,
            Image = image
        };

        return game;
    }
}
