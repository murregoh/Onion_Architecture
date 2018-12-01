using System;
using Microsoft.EntityFrameworkCore;

namespace movieRent.Infraestructure
{
    public partial class AppDbContext : DbContext
    {
        private string _StringConnection = "server=10.20.30.3; Port=1433;user id=admin;password=admin;database=movie_Rent";

        public AppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_StringConnection);
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}
