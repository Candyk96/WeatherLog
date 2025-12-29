using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeatherLog.Models;

namespace WeatherLog.Data
{
    public class WeatherLogContext : DbContext
    {
        public WeatherLogContext (DbContextOptions<WeatherLogContext> options)
            : base(options)
        {
        }

        public DbSet<WeatherLog.Models.Weather> Weather { get; set; } = default!;
    }
}
