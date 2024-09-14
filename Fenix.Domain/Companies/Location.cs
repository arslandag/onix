using CSharpFunctionalExtensions;
using Fenix.Domain.ValueObjects;
using Timer = System.Timers.Timer;

namespace Fenix.Domain.Companies;

public class Location
{
    private Location(
        Name name,
        Description description,
        Phone locationPhone,
        Address locationAddress,
        IEnumerable<Photo> locationPhotos)
    {
        Name = name;
        Description = description;
        LocationPhone = locationPhone;
        LocationAddress = locationAddress;
        _locationPhotos = locationPhotos.ToList();
    }
    
    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public Phone LocationPhone { get; private set; }
    public Address LocationAddress { get; private set; }
    public Schedule LocationSchedule { get; private set; }
    
    public IReadOnlyList<Photo> LocationPhotos => _locationPhotos;
    private readonly List<Photo> _locationPhotos = [];

    public static Result<Location> Create(
        Name name,
        Description description,
        Phone locationPhone,
        Address locationAddress,
        IEnumerable<Photo> locationPhotos)
    {
        return new Location(
            name,
            description,
            locationPhone,
            locationAddress,
            locationPhotos);
    }
}