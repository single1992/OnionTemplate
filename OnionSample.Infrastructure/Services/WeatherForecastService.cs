using Microsoft.EntityFrameworkCore;
using OnionSample.Domain.Entities;
using OnionSample.Domain.Interfaces;
using OnionSample.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnionSample.Infrastructure.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly AppDbContext dbContext;

        public WeatherForecastService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<WeatherForecast>> GetAllAsync()
        {
            return await dbContext.WeatherForecasts.ToListAsync();
        }
    }
}
