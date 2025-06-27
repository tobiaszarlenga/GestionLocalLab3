using Microsoft.EntityFrameworkCore;
using GestioLocalLab3.API.Models;
using GestionLocalLab3.API.Data.Configurations;

namespace GestionLocalLab3.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<DetalleVenta> DetallesVenta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductoConfiguration());
            modelBuilder.ApplyConfiguration(new VentaConfiguration());
            modelBuilder.ApplyConfiguration(new DetalleVentaConfiguration());
        }
    }
}
