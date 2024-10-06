using CourseProject.Domain.Enums;

public sealed record Money(string Currency, decimal Amount)
{
    public static string[] GetAllCurrencies()
    {
        return Enum
            .GetValues(typeof(CurrencyType))
            .Cast<CurrencyType>()
            .Select(x => x.ToString())
            .ToArray();
    }

    public Money ConvertToUSD()
    {
        CurrencyType type = (CurrencyType)Enum.Parse(typeof(CurrencyType), Currency, true);

        decimal amount = 0;
        switch (type)
        {
            case CurrencyType.UAH:
                amount = this.Amount / 37;
                break;
            default:
                amount = this.Amount;
                break;
        }

        return new Money(nameof(CurrencyType.USD), amount);
    }

    public Money ConvertTo(CurrencyType currencyType)
    {
        Money inUSD = ConvertToUSD();

        decimal amount = 0;
        switch (currencyType)
        {
            case CurrencyType.UAH:
                amount = inUSD * 37;
                break;
            default:
                amount = inUSD.Amount;
                break;
        }

        return new Money(currencyType.ToString(), amount);
    }

    public override string ToString()
    {
        return $"{Amount} {Currency}";
    }

    public static implicit operator decimal(Money money) => money.Amount;
}
