using CSharpFunctionalExtensions;

namespace Fenix.Domain.SharedObjects;

public class ShowStatus
{
    private ShowStatus(bool value)
    {
        Value = value;
    }
    
    public bool Value { get;}

    public static Result<ShowStatus> Create(bool value)
    {
        return new ShowStatus(value);
    }
}