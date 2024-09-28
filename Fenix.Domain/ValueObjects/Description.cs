using CSharpFunctionalExtensions;

namespace Fenix.Domain.ValueObjects;

public record Description
{
    private Description(string value)
    {
        Value = value;
    }
    
    public string Value { get; }

    public static Result<Description> Create(string value)
    {
        return new Description(value);
    }
}