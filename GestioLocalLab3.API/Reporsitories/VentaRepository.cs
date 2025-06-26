using GestioLocalLab3.API.Interface;
using GestioLocalLab3.API.Models;

namespace GestioLocalLab3.API.Repositories
{
    public class VentaRepository : IVentaRepository
    {
        private readonly List<Venta> _ventas = new List<Venta>();
        private readonly List<Producto> _productos;
        private int _nextId = 1;

        public VentaRepository(List<Producto> productos)
        {
            _productos = productos;
        }

        public List<Venta> ObtenerTodas()
        {
            return _ventas;
        }

        public Venta? ObtenerPorId(int id)
        {
            return _ventas.FirstOrDefault(v => v.Id == id);
        }

        public void Agregar(Venta venta)
        {
            // Validar stock y descontar
            foreach (var detalle in venta.Detalles)
            {
                var producto = _productos.FirstOrDefault(p => p.Id == detalle.ProductoID);
                if (producto == null)
                    throw new Exception($"Producto con ID {detalle.ProductoID} no existe.");

                if (producto.StockActual < detalle.Cantidad)
                    throw new Exception($"Stock insuficiente para el producto: {producto.Nombre}");

                producto.StockActual -= detalle.Cantidad;
            }

            venta.Id = _nextId++;
            _ventas.Add(venta);
        }

        public void Editar(Venta ventaEditada)
        {
            var ventaOriginal = _ventas.FirstOrDefault(v => v.Id == ventaEditada.Id);
            if (ventaOriginal == null)
                throw new Exception("Venta no encontrada.");

            // 1. Devolver al stock los productos originales
            foreach (var detalle in ventaOriginal.Detalles)
            {
                var producto = _productos.FirstOrDefault(p => p.Id == detalle.ProductoID);
                if (producto != null)
                    producto.StockActual += detalle.Cantidad;
            }

            // 2. Validar stock y descontar los nuevos productos
            foreach (var detalle in ventaEditada.Detalles)
            {
                var producto = _productos.FirstOrDefault(p => p.Id == detalle.ProductoID);
                if (producto == null)
                    throw new Exception($"Producto con ID {detalle.ProductoID} no existe.");

                if (producto.StockActual < detalle.Cantidad)
                    throw new Exception($"Stock insuficiente para el producto: {producto.Nombre}");

                producto.StockActual -= detalle.Cantidad;
            }

            // 3. Actualizar los datos de la venta
            ventaOriginal.Fecha = ventaEditada.Fecha;
            ventaOriginal.MontoTotal = ventaEditada.MontoTotal;
            ventaOriginal.MetodoPago = ventaEditada.MetodoPago;
            ventaOriginal.Detalles = ventaEditada.Detalles;
        }

        public void Eliminar(int ventaId)
        {
            var venta = _ventas.FirstOrDefault(v => v.Id == ventaId);
            if (venta == null)
                throw new Exception("Venta no encontrada.");

            // Devolver productos al stock
            foreach (var detalle in venta.Detalles)
            {
                var producto = _productos.FirstOrDefault(p => p.Id == detalle.ProductoID);
                if (producto != null)
                    producto.StockActual += detalle.Cantidad;
            }

            _ventas.Remove(venta);
        }

    }
}
