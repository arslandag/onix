using CSharpFunctionalExtensions;

namespace Fenix.Domain.ValueObjects;

public class Phone
{
    private Phone(string value)
    {
        Value = value;
    }
    
    public string Value { get; }

    public static Result<Phone> Create(string value)
    {
        return new Phone(value);
    }
}