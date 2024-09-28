using Fenix.Domain.Entities;
using Fenix.Domain.Shared;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fenix.Infrastructure.DateBase.Configurations.Write;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("employee");
        
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .HasConversion(
                id => id.Value,
                value => EmployeeId.Create(value))
            .HasColumnName("employee_id");

        builder.ComplexProperty(e => e.FullName, tb =>
        {
            tb.Property(l => l.LastName)
                .HasMaxLength(Constants.NAME_MAX_LENGHT)
                .IsRequired(false)
                .HasColumnName("lastname");
            
            tb.Property(f => f.FirstName)
                .HasMaxLength(Constants.NAME_MAX_LENGHT)
                .IsRequired()
                .HasColumnName("firstname");

            tb.Property(p => p.Patronymic)
                .HasMaxLength(Constants.NAME_MAX_LENGHT)
                .IsRequired(false)
                .HasColumnName("patronymic");
        });

        builder.ComplexProperty(e => e.Description, tb =>
        {
            tb.Property(d => d.Value)
                .IsRequired(false)
                .HasMaxLength(Constants.DESCRIPTION_MAX_LENGHT)
                .HasColumnName("description");
        });

        builder.ComplexProperty(e => e.Link, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired(false)
                .HasMaxLength(Constants.LINK_MAX_LENGHT)
                .HasColumnName("link");
        });

        builder.HasOne(e => e.EmployeePhoto)
            .WithOne()
            .HasForeignKey("employee_id")
            .IsRequired(false);
    }
}