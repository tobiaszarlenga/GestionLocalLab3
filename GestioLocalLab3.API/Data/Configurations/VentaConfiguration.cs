using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GestioLocalLab3.API.Models;

namespace GestionLocalLab3.API.Data.Configurations
{
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("Venta");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.MetodoPago)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(v => v.Fecha)
                   .IsRequired();

            // Relación con DetalleVenta
            builder.HasMany(v => v.Detalles)
                   .WithOne(d => d.Venta)
                   .HasForeignKey(d => d.VentaId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
