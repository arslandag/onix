using CSharpFunctionalExtensions;

namespace Fenix.Domain.SharedObjects;

public record Price
{
    private Price(string value)
    {
        Value = value;
    }
    
    public string Value { get; }

    public static Result<Price> Create(string value)
    {
        return new Price(value);
    }
}