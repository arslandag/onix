using CSharpFunctionalExtensions;

namespace Fenix.Domain.SharedObjects;

public record Industry
{
    private Industry(IndustryType value)
    {
        Value = value;
    }
    
    public IndustryType Value { get; }

    public static Result<Industry> Create(IndustryType value)
    {
        return new Industry(value);
    }
}