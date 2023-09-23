using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration; 
using Mystore.Entities;



namespace Mystore.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("MyDbConnection"));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<NonNutritionalProduct> NonNutritionalProducts { get; set; }
        public DbSet<NutritionalProduct> NutritionalProduct { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().UseTpcMappingStrategy();

            modelBuilder.Entity<NonNutritionalProduct>().ToTable("NonNutritionalProduct");
            modelBuilder.Entity<NutritionalProduct>().ToTable("NutritionalProducts");

        }
    }
}


