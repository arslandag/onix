namespace Fenix.Domain.Shared.ValueObjects.Ids;

public class EmployeeId
{
    private EmployeeId(Guid value)
    {
        Value = value;
    }
    
    public Guid Value { get; }

    public static EmployeeId NewUserId() => new(Guid.NewGuid());
    public static EmployeeId Empty() => new(Guid.Empty);
    public static EmployeeId Create(Guid id) => new(id);
}