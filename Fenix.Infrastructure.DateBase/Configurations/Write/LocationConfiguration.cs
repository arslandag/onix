using Fenix.Domain.Locations;
using Fenix.Domain.Shared;
using Fenix.Domain.Shared.ValueObjects.Ids;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fenix.Infrastructure.DateBase.Configurations.Write;

public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.ToTable("location");

        builder.HasKey(l => l.Id);

        builder.Property(l => l.Id)
            .HasConversion(
                id => id.Value,
                value => LocationId.Create(value))
            .HasColumnName("location_id");

        builder.ComplexProperty(l => l.Name, tb =>
        {
            tb.Property(n => n.Value)
                .IsRequired()
                .HasMaxLength(Constants.NAME_MAX_LENGHT)
                .HasColumnName("name");
        });
        
        builder.ComplexProperty(l => l.LocationPhone, tb =>
        {
            tb.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(Constants.PHONE_MAX_LENGHT)
                .HasColumnName("phone");
        });
        
        builder.ComplexProperty(l => l.LocationAddress, tb =>
        {
            tb.Property(p => p.Country)
                .IsRequired()
                .HasMaxLength(Constants.ADDRESS_MAX_LENGHT)
                .HasColumnName("country");
            
            tb.Property(p => p.City)
                .IsRequired()
                .HasMaxLength(Constants.ADDRESS_MAX_LENGHT)
                .HasColumnName("country");
            
            tb.Property(p => p.Street)
                .IsRequired()
                .HasMaxLength(Constants.ADDRESS_MAX_LENGHT)
                .HasColumnName("street");
            
            tb.Property(p => p.Build)
                .IsRequired()
                .HasMaxLength(Constants.ADDRESS_MAX_LENGHT)
                .HasColumnName("build");
            
            tb.Property(p => p.Index)
                .IsRequired(false)
                .HasMaxLength(Constants.INDEX_MAX_LENGHT)
                .HasColumnName("index");
        });
        
        builder.ComplexProperty(l => l.LocationSchedule, tb =>
        {
            tb.Property(p => p.WeekDay)
                .IsRequired()
                .HasMaxLength(Constants.WEEKDAY_MAX_LENGHT)
                .HasColumnName("weekday");
            
            tb.Property(p => p.StartTime)
                .IsRequired()
                .HasMaxLength(Constants.TIME_MAX_LENGHT)
                .HasColumnName("starttime");
            
            tb.Property(p => p.EndTime)
                .IsRequired()
                .HasMaxLength(Constants.TIME_MAX_LENGHT)
                .HasColumnName("endTime");
        });
    }
}