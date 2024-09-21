using CSharpFunctionalExtensions;

namespace Fenix.Domain.SharedObjects;

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