using CryptoWatch.Domain.Exceptions;

namespace CryptoWatch.Domain.ValueObjects;

public record Money
{
    public decimal Value { get; }

    public Money(decimal value)
    {
        if (value <= 0)
        {
            throw new DomainException("Valor deve ser maior que zero.");
        }
        Value = value;
    }
}