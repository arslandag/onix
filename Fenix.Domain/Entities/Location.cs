using CSharpFunctionalExtensions;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.SharedObjects;
using Fenix.Domain.ValueObjects;

namespace Fenix.Domain.Entities;

public class Location : Shared.Entity<LocationId>
{
    private Location(
        LocationId id,
        Name name,
        Phone locationPhone,
        Address locationAddress,
        Schedule locationSchedule) : base(id)
    {
        Name = name;
        LocationPhone = locationPhone;
        LocationAddress = locationAddress;
        LocationSchedule = locationSchedule;
    }
    
    public Name Name { get; private set; }
    public Phone LocationPhone { get; private set; }
    public Address LocationAddress { get; private set; }
    
    public Schedule LocationSchedule { get; private set; }
    
    public static Result<Location> Create(
        LocationId id,
        Name name,
        Phone locationPhone,
        Address locationAddress,
        Schedule locationSchedule)
    {
        return new Location(
            id,
            name,
            locationPhone,
            locationAddress,
            locationSchedule);
    }
}