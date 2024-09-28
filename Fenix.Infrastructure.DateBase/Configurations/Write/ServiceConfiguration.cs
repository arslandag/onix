using Fenix.Domain.Entities;
using Fenix.Domain.Shared;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Fenix.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fenix.Infrastructure.DateBase.Configurations.Write;

public class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.ToTable("service");

        builder.HasKey(s => s.Id);

        builder.Property(s => s.Id)
            .HasConversion(
                id => id.Value,
                value => ServiceId.Create(value))
            .HasColumnName("service_id");

        builder.ComplexProperty(s => s.Name, tb =>
        {
            tb.Property(n => n.Value)
                .IsRequired()
                .HasMaxLength(Constants.NAME_MAX_LENGHT)
                .HasColumnName("name");
        });

        builder.ComplexProperty(s => s.Description, tb =>
        {
            tb.Property(d => d.Value)
                .IsRequired(false)
                .HasMaxLength(Constants.DESCRIPTION_MAX_LENGHT)
                .HasColumnName("description");
        });

        builder.ComplexProperty(s => s.Price, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired(false)
                .HasColumnName("price");
        });

        builder.ComplexProperty(s => s.Duration, tb =>
        {
            tb.Property(d => d.Value)
                .IsRequired(false)
                .HasColumnName("duration");
        });
        
        builder.ComplexProperty(s => s.Link, tb =>
        {
            tb.Property(d => d.Value)
                .IsRequired(false)
                .HasMaxLength(Constants.LINK_MAX_LENGHT)
                .HasColumnName("link");
        });

        builder.HasMany(s => s.ServicePhotos)
            .WithOne()
            .HasForeignKey("service_id")
            .IsRequired(false);
    }
}