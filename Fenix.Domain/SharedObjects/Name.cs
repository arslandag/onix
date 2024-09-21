using CSharpFunctionalExtensions;

namespace Fenix.Domain.SharedObjects;

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