using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OnionSample.Domain.Entities;
using OnionSample.Infrastructure.Data.Seeds;
using System.Reflection;

namespace OnionSample.Infrastructure.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<WeatherForecast>().HasData(WeatherForecastSeed.Create());
        }
    }
}
