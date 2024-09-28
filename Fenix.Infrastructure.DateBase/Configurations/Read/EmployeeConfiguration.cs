using Fenix.Application.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fenix.Infrastructure.DateBase.Configurations.Read;

public class EmployeeConfiguration : IEntityTypeConfiguration<EmployeeDto>
{
    public void Configure(EntityTypeBuilder<EmployeeDto> builder)
    {
        builder.ToTable("employee");
        
        builder.HasKey(e => e.Id);

        builder.HasOne(e => e.Photo)
            .WithOne()
            .HasForeignKey("employee_id");
    }
}