using CourseProject.Domain.Primitives;
using CourseProject.Domain.ValueObjects.Comment;
using CourseProject.Domain.ValueObjects.Identificators;

namespace CourseProject.Domain.Entities;

public sealed class Comment : Entity
{
    public Comment(Guid id) 
        : base(id)
    {
    }

    public Guid AuthorId { get; private set; }
    public CommentText Text { get; private set; }
    public Guid GameId { get; private set; }
    public CommentCreationDate CreationDate { get; private set; }

    public static Comment Create(UserId authorId, CommentText text, GameId gameId)
    {
        Guid id = Guid.NewGuid();

        var comment = new Comment(id)
        {
            AuthorId = authorId.Value,
            Text = text,
            GameId = gameId.Value,
            CreationDate = CommentCreationDate.Create(DateTime.Now).Value
        };

        return comment;
    }
}
