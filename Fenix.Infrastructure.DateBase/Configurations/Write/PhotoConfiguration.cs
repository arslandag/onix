using Fenix.Domain.Entities;
using Fenix.Domain.Shared;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fenix.Infrastructure.DateBase.Configurations.Write;

public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
{
    public void Configure(EntityTypeBuilder<Photo> builder)
    {
        builder.ToTable("photo");

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Id)
            .HasConversion(
                id => id.Value,
                value => PhotoId.Create(value))
            .HasColumnName("photo_id");

        builder.ComplexProperty(p => p.Path, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(Constants.PATH_MAX_LENGHT)
                .HasColumnName("path");
        });
    }
}