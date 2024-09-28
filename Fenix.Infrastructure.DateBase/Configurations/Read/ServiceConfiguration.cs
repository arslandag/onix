using Fenix.Application.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fenix.Infrastructure.DateBase.Configurations.Read;

public class ServiceConfiguration : IEntityTypeConfiguration<ServiceDto>
{
    public void Configure(EntityTypeBuilder<ServiceDto> builder)
    {
        builder.ToTable("service");

        builder.HasKey(s => s.Id);

        builder.HasMany(s => s.Photos)
            .WithOne()
            .HasForeignKey("service_id");
    }
}