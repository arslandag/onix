using CSharpFunctionalExtensions;

namespace Fenix.Domain.ValueObjects;

public record Name
{
    private Name(string value)
    {
        Value = value;
    }
    
    public string Value { get; }

    public static Result<Name> Create(string value)
    {
        return new Name(value);
    }
}