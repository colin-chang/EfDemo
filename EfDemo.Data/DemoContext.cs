using EfDemo.Domain;
using Microsoft.EntityFrameworkCore;

namespace EfDemo.Data
{
    public class DemoContext : DbContext
    {
        private const string ConnectionString = "Server=127.0.0.1;Port=3306;Database=demo;User=root;Password=123123;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseMySql(ConnectionString, ServerVersion.AutoDetect(ConnectionString));

        public DbSet<League> Leagues { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}