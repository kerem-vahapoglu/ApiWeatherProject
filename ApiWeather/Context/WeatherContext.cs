using ApiWeather.Entitites;
using Microsoft.EntityFrameworkCore;

namespace ApiWeather.Context
{
    public class WeatherContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-LKTU092;Initial Catalog=Db_ApiWeather;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;");

        }

        public DbSet<City>Cities { get; set; }
    }
}
