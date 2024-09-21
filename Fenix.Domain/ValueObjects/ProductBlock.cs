using CSharpFunctionalExtensions;
using Fenix.Domain.Entities;
using Fenix.Domain.SharedObjects;

namespace Fenix.Domain.ValueObjects;

public class ProductBlock : Block
{
    private ProductBlock(
        Title title,
        ShowStatus showStatus,
        IEnumerable<Product> products)
    {
        Title = title;
        ShowStatus = showStatus;
        _products = products.ToList();
    }

    public Title Title { get; }
    public ShowStatus ShowStatus { get; }
    
    public IReadOnlyList<Product> Products => _products;
    private readonly List<Product> _products = [];

    public static Result<ProductBlock> Create(
        Title title,
        ShowStatus showStatus,
        IEnumerable<Product> products)
    {
        return new ProductBlock(title, showStatus, products);
    }
}