namespace Fenix.Domain.Shared.ValueObjects.Ids;

public record UserId
{
    private UserId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }

    public static UserId NewUserId() => new(Guid.NewGuid());
    public static UserId Empty() => new(Guid.Empty);
    public static UserId Create(Guid id) => new(id);
}