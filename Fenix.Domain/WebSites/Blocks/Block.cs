using CSharpFunctionalExtensions;
using Fenix.Domain.Entities;
using Fenix.Domain.Locations;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.ValueObjects;
using Fenix.Domain.WebSites.ValueObjects;

namespace Fenix.Domain.WebSites.Blocks;

public class Block : Shared.Entity<BlockId>
{
    private Block(
        BlockId id,
        Title title,
        Description description,
        Photo backgroundPhoto) : base(id)
    {
        Title = title;
        Description = description;
        BackgroundPhoto = backgroundPhoto;
    }
    
    public Title Title { get; private set; }
    public Description Description { get; private set; }
    public Photo BackgroundPhoto { get; private set; }
    
    public IReadOnlyList<Location> Locations => _locations;
    private readonly List<Location> _locations = [];
    
    public IReadOnlyList<Service> Services => _services;
    private readonly List<Service> _services = [];
    
    public IReadOnlyList<Product> Products => _products;
    private readonly List<Product> _products = [];
    
    public IReadOnlyList<Employee> Employees => _employees;
    private readonly List<Employee> _employees = [];
    
    public IReadOnlyList<Photo> Photos => _photos;
    private readonly List<Photo> _photos = [];

    public static Result<Block> Create(
        BlockId id,
        Title title,
        Description description,
        Photo backgroundPhoto)
    {
        return new Block(
            id,
            title,
            description,
            backgroundPhoto);
    }
}