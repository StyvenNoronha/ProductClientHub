using Microsoft.EntityFrameworkCore;
using ProductClientHub.API.Entities;

namespace ProductClientHub.API.Infraestructure
{
    public class ProductClientHubDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=D:\\microsoft\\1737062251373-attachment.octet-stream");
        }
    }
}
