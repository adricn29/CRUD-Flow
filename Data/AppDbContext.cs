using Microsoft.EntityFrameworkCore;
using CRUDApp.Models;

namespace CRUDApp.Data  // Asegúrate de que esté en este namespace o similar
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Producto> Productos { get; set; }
    }
}
