using CSharpFunctionalExtensions;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.ValueObjects;

namespace Fenix.Domain.Entities;

public class Service : Shared.Entity<ServiceId>
{
    private Service(
        ServiceId id,
        Name name,
        Description? description,
        Price? price,
        Duration? duration,
        Link? link) : base(id)
    {
        Name = name;
        Description = description;
        Price = price;
        Duration = duration;
        Link = link;
    }

    public Name Name { get; private set; }
    public Description? Description { get; private set; }
    public Price? Price { get; private set; }
    public Duration? Duration { get; private set; }
    public Link? Link { get; private set; }
    
    public IReadOnlyList<Photo> ServicePhotos => _servicePhotos ;
    private readonly List<Photo> _servicePhotos = [];

    public static Result<Service> Create(
        ServiceId id,
        Name name,
        Description? description,
        Price? price,
        Duration? duration,
        Link? link)
    {
        return new Service(
            id,
            name,
            description,
            price,
            duration,
            link);
    }
}