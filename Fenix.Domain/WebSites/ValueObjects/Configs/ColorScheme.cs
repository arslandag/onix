using CSharpFunctionalExtensions;

namespace Fenix.Domain.WebSites.ValueObjects.Configs;

public record ColorScheme
{
    private  ColorScheme(string value)
    {
        Value = value;
    }
    
    public string Value { get; }

    public static Result<ColorScheme> Create(string value)
    {
        return new ColorScheme(value);
    }
}