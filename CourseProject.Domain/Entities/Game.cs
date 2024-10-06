using CourseProject.Domain.Enums;
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
    public GameCreationDate CreationDate { get; private set; }
    public Money Price { get; private set; }
    public GameGenre Genre { get; private set; }
    public Guid AuthorId { get; private set; }
    public GameDescription Description { get; private set; }
    public GameIcon Image { get; private set; }
    public List<Comment> Comments { get; private set; }

    public static Game Create(GameTitle title, GameCreationDate creationDate, Money price, GameGenre genre, UserId authorId, GameDescription description, GameIcon image)
    {
        Guid id = Guid.NewGuid();

        var game = new Game(id)
        {
            Title = title,
            CreationDate = creationDate,
            Price = price,
            Genre = genre,
            AuthorId = authorId.Value,
            Description = description,
            Image = image
        };

        return game;
    }
}
