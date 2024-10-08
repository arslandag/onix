using CSharpFunctionalExtensions;

namespace Fenix.Domain.WebSites.ValueObjects;

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