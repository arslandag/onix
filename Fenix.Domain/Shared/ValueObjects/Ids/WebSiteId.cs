namespace Fenix.Domain.Shared.ValueObjects.Ids;

public record WebSiteId
{
    private WebSiteId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }

    public static WebSiteId NewUserId() => new(Guid.NewGuid());
    public static WebSiteId Empty() => new(Guid.Empty);
    public static WebSiteId Create(Guid id) => new(id);
}