using System;
using Microsoft.EntityFrameworkCore;

namespace movieRent.Infraestructure
{
    public partial class AppDbContext : DbContext
    {
        private string _StringConnection = "server=localhost; Port=0000;user id=admin;password=admin;database=admin_movieRent";

        public AppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_StringConnection);
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}
