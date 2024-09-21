namespace Fenix.Domain.Shared.ValueObjects.Ids;

public class ServiceId
{
    private ServiceId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }

    public static ServiceId NewUserId() => new(Guid.NewGuid());
    public static ServiceId Empty() => new(Guid.Empty);
    public static ServiceId Create(Guid id) => new(id);
}