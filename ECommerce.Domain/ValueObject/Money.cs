namespace ECommerce.Domain.ValueObject;

public record Money
{
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    public Money(decimal amount, string currency)
    {
        if (amount < 0)
            throw new ArgumentException("Amount cannot be negative", nameof(amount));
        if (string.IsNullOrWhiteSpace(currency))
            throw new ArgumentException("Currency is required", nameof(currency));

        Amount = amount;
        Currency = currency;
    }
}
