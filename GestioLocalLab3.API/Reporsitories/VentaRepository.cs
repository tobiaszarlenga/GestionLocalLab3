using GestioLocalLab3.API.Interface;
using GestionLocalLab3.API.Data;

using GestioLocalLab3.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionLocalLab3.API.Repositories
{
    public class VentaRepository : IVentaRepository
    {
        private readonly AppDbContext _context;

        public VentaRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Venta> ObtenerTodas()
        {
            return _context.Ventas
                .Include(v => v.Detalles)
                .ThenInclude(d => d.Producto)
                .ToList();
        }

        public Venta? ObtenerPorId(int id)
        {
            return _context.Ventas
                .Include(v => v.Detalles)
                .ThenInclude(d => d.Producto)
                .FirstOrDefault(v => v.Id == id);
        }

        public void Agregar(Venta venta)
        {

            foreach (var detalle in venta.Detalles)
            {
                var producto = _context.Productos
                    .FirstOrDefault(p => p.Id == detalle.ProductoID);

                if (producto == null)
                    throw new Exception($"Producto con ID {detalle.ProductoID} no existe.");

                if (producto.StockActual < detalle.Cantidad)
                    throw new Exception($"Stock insuficiente para el producto: {producto.Nombre}");

                producto.StockActual -= detalle.Cantidad;

                detalle.PrecioUnitario = producto.Precio;

                // 🔥 ESTA LÍNEA arregla el error
                detalle.Producto = null;
            }

            venta.Fecha = DateTime.Now;
            _context.Ventas.Add(venta);
            _context.SaveChanges();
        }

        public void Editar(Venta ventaEditada)
        {
            var ventaOriginal = _context.Ventas
                .Include(v => v.Detalles)
                .FirstOrDefault(v => v.Id == ventaEditada.Id);

            if (ventaOriginal == null)
                throw new Exception("Venta no encontrada.");

            // Devolver stock de la venta original
            foreach (var detalle in ventaOriginal.Detalles)
            {
                var producto = _context.Productos
                    .FirstOrDefault(p => p.Id == detalle.ProductoID);

                if (producto != null)
                    producto.StockActual += detalle.Cantidad;
            }

            // Validar y descontar stock para la nueva venta
            foreach (var detalle in ventaEditada.Detalles)
            {
                var producto = _context.Productos
                    .FirstOrDefault(p => p.Id == detalle.ProductoID);

                if (producto == null)
                    throw new Exception($"Producto con ID {detalle.ProductoID} no existe.");

                if (producto.StockActual < detalle.Cantidad)
                    throw new Exception($"Stock insuficiente para el producto: {producto.Nombre}");

                producto.StockActual -= detalle.Cantidad;
                detalle.PrecioUnitario = producto.Precio;
            }

            // Actualizar venta
            ventaOriginal.MetodoPago = ventaEditada.MetodoPago;
            ventaOriginal.Fecha = ventaEditada.Fecha;
            ventaOriginal.Detalles = ventaEditada.Detalles;

            _context.SaveChanges();
        }

        public void Eliminar(int ventaId)
        {
            var venta = _context.Ventas
                .Include(v => v.Detalles)
                .FirstOrDefault(v => v.Id == ventaId);

            if (venta == null)
                throw new Exception("Venta no encontrada.");

            foreach (var detalle in venta.Detalles)
            {
                var producto = _context.Productos
                    .FirstOrDefault(p => p.Id == detalle.ProductoID);

                if (producto != null)
                    producto.StockActual += detalle.Cantidad;
            }

            _context.Ventas.Remove(venta);
            _context.SaveChanges();
        }
    }
}
