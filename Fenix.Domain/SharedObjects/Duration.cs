using CSharpFunctionalExtensions;

namespace Fenix.Domain.SharedObjects;

public record Duration
{
    private Duration(int value)
    {
        Value = value; 
    }
    
    public int Value { get; private set; }

    public static Result<Duration> Create(int value)
    {
        return new Duration(value);
    }
}