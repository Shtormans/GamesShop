public sealed record Money(string Currency, decimal Amount)
{
    public static implicit operator decimal(Money money) => money.Amount;
}
