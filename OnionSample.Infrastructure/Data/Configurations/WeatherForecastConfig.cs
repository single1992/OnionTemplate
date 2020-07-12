using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionSample.Domain.Entities;

namespace OnionSample.Infrastructure.Data.Configurations
{
    public class WeatherForecastConfig : IEntityTypeConfiguration<WeatherForecast>
    {
        public void Configure(EntityTypeBuilder<WeatherForecast> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Ignore(x => x.TemperatureF);

            builder.Property(x => x.TemperatureC)
                .HasColumnName("TemperatureC")
                .IsRequired();

            builder.Property(x => x.Summary)
                .HasColumnName("Summary")
                .HasMaxLength(64)
                .IsRequired();

            builder.Property(x => x.Date)
                .HasColumnName("Date")
                .IsRequired();

            builder.ToTable("WeatherForecasts");
        }
    }
}
