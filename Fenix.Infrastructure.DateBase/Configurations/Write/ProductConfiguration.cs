using Fenix.Domain.Entities;
using Fenix.Domain.Shared;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fenix.Infrastructure.DateBase.Configurations.Write;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("block");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .HasConversion(
                id => id.Value,
                value => ProductId.Create(value))
            .HasColumnName("product_id");

        builder.ComplexProperty(p => p.Name, tb =>
        {
            tb.Property(n => n.Value)
                .IsRequired()
                .HasMaxLength(Constants.NAME_MAX_LENGHT)
                .HasColumnName("product");
        });
        
        builder.ComplexProperty(p => p.Description, tb =>
        {
            tb.Property(n => n.Value)
                .IsRequired(false)
                .HasMaxLength(Constants.DESCRIPTION_MAX_LENGHT)
                .HasColumnName("description");
        });
        
        builder.ComplexProperty(p => p.Price, tb =>
        {
            tb.Property(n => n.Value)
                .IsRequired(false)
                .HasColumnName("price");
        });
        
        builder.ComplexProperty(p => p.Link, tb =>
        {
            tb.Property(l => l.Value)
                .IsRequired(false)
                .HasMaxLength(Constants.LINK_MAX_LENGHT)
                .HasColumnName("link");
        });

        builder.HasMany(p => p.ProductPhotos)
            .WithOne()
            .HasForeignKey("product_id")
            .IsRequired(false);
    }
}