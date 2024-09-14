namespace Fenix.Domain.Shared.ValueObjects.Ids;

public record CompanyId
{
    private CompanyId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; init; }

    public static CompanyId NewUserId() => new(Guid.NewGuid());
    public static CompanyId Empty() => new(Guid.Empty);
    public static CompanyId Create(Guid id) => new(id);
}