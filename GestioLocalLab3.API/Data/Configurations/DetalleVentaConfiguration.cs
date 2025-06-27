using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GestioLocalLab3.API.Models;

namespace GestionLocalLab3.API.Data.Configurations
{
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("DetalleVenta");

            builder.HasKey(d => d.ID);

            builder.Property(d => d.Cantidad)
                   .IsRequired();

            builder.Property(d => d.PrecioUnitario)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.HasOne(d => d.Producto)
                   .WithMany()
                   .HasForeignKey(d => d.ProductoID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
