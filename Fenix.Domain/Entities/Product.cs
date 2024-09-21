using CSharpFunctionalExtensions;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.SharedObjects;

namespace Fenix.Domain.Entities;

public class Product : Shared.Entity<ProductId>
{
    private Product(
        ProductId id,
        Name name,
        Description description,
        Category category,
        Price price,
        IEnumerable<Photo> productPhotos) : base(id)
    {
        Name = name;
        Description = description;
        Category = category;
        Price = price;
        _productPhotos = productPhotos.ToList();
    }
    
    public Name Name {get;}
    public Description Description { get; }

    public Price Price { get; }
    public Category Category { get; }
    
    public IReadOnlyList<Photo> ProductPhotos => _productPhotos ;
    private readonly List<Photo> _productPhotos = [];

    public static Result<Product> Create(
        ProductId id,
        Name name,
        Description description,
        Category category,
        Price price,
        IEnumerable<Photo> productPhotos)
    {
        return new Product(
            id,
            name,
            description,
            category,
            price,
            productPhotos); 
    }
}