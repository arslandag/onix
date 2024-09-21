using CSharpFunctionalExtensions;

namespace Fenix.Domain.SharedObjects;

public record Category
{
    private Category(string value)
    {
        Value = value;
    }
    
    public string Value { get; }

    public static Result<Category> Create(string value)
    {
        return new Category(value);
    }
}