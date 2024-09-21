using CSharpFunctionalExtensions;
using Fenix.Domain.Entities;
using Fenix.Domain.SharedObjects;

namespace Fenix.Domain.ValueObjects;

public class ProductBlock : Block
{
    private ProductBlock(
        Name name,
        ShowStatus showStatus,
        IEnumerable<Product> products)
    {
        Name = name;
        ShowStatus = showStatus;
        _products = products.ToList();
    }

    public Name Name { get; private set; }
    public ShowStatus ShowStatus { get; private set; }
    
    public IReadOnlyList<Product> Products => _products;
    private readonly List<Product> _products = [];

    public static Result<ProductBlock> Create(
        Name name,
        ShowStatus showStatus,
        IEnumerable<Product> products)
    {
        return new ProductBlock(name, showStatus, products);
    }
}