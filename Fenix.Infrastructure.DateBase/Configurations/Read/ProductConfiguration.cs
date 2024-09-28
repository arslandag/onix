using Fenix.Application.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fenix.Infrastructure.DateBase.Configurations.Read;

public class ProductConfiguration : IEntityTypeConfiguration<ProductDto>
{
    public void Configure(EntityTypeBuilder<ProductDto> builder)
    {
        builder.ToTable("block");

        builder.HasKey(p => p.Id);
        
        builder.HasMany(p => p.Photos)
            .WithOne()
            .HasForeignKey("product_id");
    }
}