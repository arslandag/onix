using CSharpFunctionalExtensions;

namespace Fenix.Domain.Users.ValueObjects;

public record Email
{
    private Email(string value)
    {
        Value = value;
    }
    
    public string Value { get; }

    public static Result<Email> Create(string value)
    {
        return new Email(value);
    }
}