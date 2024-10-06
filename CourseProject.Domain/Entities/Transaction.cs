using CourseProject.Domain.Primitives;
using CourseProject.Domain.Shared;
using CourseProject.Domain.ValueObjects.Identificators;
using CourseProject.Domain.ValueObjects.Transaction;

namespace CourseProject.Domain.Entities;

public sealed class Transaction : Entity
{
    private Transaction(Guid id) 
        : base(id)
    {
    }

    public Guid PayerId { get; private set; }
    public Guid ReceiverId { get; private set; }
    public Guid GameId { get; private set; }
    public Money Price { get; private set; }
    public PurchaseDate PurchaseDate { get; private set; }

    public User Payer { get; private set; }
    public User Receiver { get; private set; }
    public Game Game { get; private set; }

    public static Result<Transaction> Create(UserId payerId, UserId receiverId, GameId gameId, Money price)
    {
        Guid id = Guid.NewGuid();

        Transaction transaction = new Transaction(id)
        {
            PayerId = payerId.Value,
            ReceiverId = receiverId.Value,
            GameId = gameId.Value,
            Price = price,
            PurchaseDate = PurchaseDate.Create(DateTime.Now).Value
        };

        return transaction;
    }
}
