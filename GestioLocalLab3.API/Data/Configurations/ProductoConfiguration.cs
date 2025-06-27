using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GestioLocalLab3.API.Models;


namespace GestionLocalLab3.API.Data.Configurations
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Producto");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nombre)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(p => p.Talle)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(p => p.Precio)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(p => p.StockActual)
                   .IsRequired();
        }
    }
}
