using CSharpFunctionalExtensions;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.ValueObjects;

namespace Fenix.Domain.Entities;

public class Product : Shared.Entity<ProductId>
{
    private Product(
        ProductId id,
        Name name,
        Description? description,
        Price? price,
        Link? link) : base(id)
    {
        Name = name;
        Description = description;
        Price = price;
        Link = link;
    }
    
    public Name Name {get; private set; }
    public Description? Description { get; private set; }
    public Price? Price { get; private set; }
    public Link? Link { get; private set; }
    
    public IReadOnlyList<Photo> ProductPhotos => _productPhotos ;
    private readonly List<Photo> _productPhotos = [];

    public static Result<Product> Create(
        ProductId id,
        Name name,
        Description? description,
        Price? price,
        Link? link)
    {
        return new Product(
            id,
            name,
            description,
            price,
            link); 
    }
}