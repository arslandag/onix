namespace Fenix.Domain.Shared.ValueObjects.Ids;

public class ProductId
{
    private ProductId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get;}

    public static ProductId NewUserId() => new(Guid.NewGuid());
    public static ProductId Empty() => new(Guid.Empty);
    public static ProductId Create(Guid id) => new(id);
}