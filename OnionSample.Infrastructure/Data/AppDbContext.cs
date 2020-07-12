using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OnionSample.Domain.Entities;
using OnionSample.Infrastructure.Data.Seeds;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace OnionSample.Infrastructure.Data
{
    public class AppDbContext: DbContext
    {
        private readonly IConfiguration configuration;

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
        {
            Database.EnsureCreated();
            this.configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<WeatherForecast>().HasData(WeatherForecastSeed.Create());
        }
    }
}
