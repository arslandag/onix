using Fenix.Domain.Shared;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.WebSites.Blocks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fenix.Infrastructure.DateBase.Configurations.Write;

public class BlockConfiguration : IEntityTypeConfiguration<Block>
{
    public void Configure(EntityTypeBuilder<Block> builder)
    {
        builder.ToTable("block");

        builder.HasKey(b => b.Id);

        builder.Property(b => b.Id)
            .HasConversion(
                id => id.Value,
                value => BlockId.Create(value))
            .HasColumnName("block_id");

        builder.ComplexProperty(b => b.Title, tb =>
        {
            tb.Property(t => t.Value)
                .IsRequired()
                .HasMaxLength(Constants.TITLE_MAX_LENGHT)
                .HasColumnName("title");
        });
        
        builder.ComplexProperty(b => b.Description, tb =>
        {
            tb.Property(d => d.Value)
                .IsRequired()
                .HasMaxLength(Constants.DESCRIPTION_MAX_LENGHT)
                .HasColumnName("description");
        });
        
        builder.ComplexProperty(b => b.BackgroundPhoto, tb =>
        {
            tb.Property(b => b.Path)
                .IsRequired(false)
                .HasMaxLength(Constants.PATH_MAX_LENGHT)
                .HasColumnName("backgroundphoto");
        });
        
        builder.HasMany(b => b.Products)
            .WithOne()
            .HasForeignKey("block_id")
            .IsRequired(false);
        
        builder.HasMany(b => b.Services)
            .WithOne()
            .HasForeignKey("block_id")
            .IsRequired(false);
        
        builder.HasMany(b => b.Employees)
            .WithOne()
            .HasForeignKey("block_id")
            .IsRequired(false);
        
        builder.HasMany(b => b.Photos)
            .WithOne()
            .HasForeignKey("block_id")
            .IsRequired(false);

        builder.HasMany(b => b.Locations)
            .WithOne()
            .HasForeignKey("block_id")
            .IsRequired(false);
    }
}