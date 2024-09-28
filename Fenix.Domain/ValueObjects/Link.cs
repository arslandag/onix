using CSharpFunctionalExtensions;

namespace Fenix.Domain.ValueObjects;

public class Link
{
    private Link(string Value)
    {
        Value = Value;
    }
    
    public string Value { get; }

    public static Result<Link> Create(string value)
    {
        return new Link(value);
    }
}