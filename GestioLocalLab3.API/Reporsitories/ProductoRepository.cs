using GestioLocalLab3.API.Interface;
using GestioLocalLab3.API.Models;

namespace GestionLocalLab3.API.Repositories
{
    public class ProductoRepository : IProductoRepository

    {

        private readonly List<Producto> _productos = new();

        public List<Producto> ObtenerTodos()
        {
            return _productos;
        }

        public Producto? ObtenerPorId(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id);
        }

        public void Agregar(Producto producto)
        {
            producto.Id = _productos.Count > 0 ? _productos.Max(p => p.Id) + 1 : 1;
            _productos.Add(producto);
        }

        public void Actualizar(Producto producto)
        {
            var existente = ObtenerPorId(producto.Id);
            if (existente != null)
            {
                existente.Nombre = producto.Nombre;
                existente.Talle = producto.Talle;
                existente.Precio = producto.Precio;
                existente.StockActual = producto.StockActual;
            }
        }

        public void Eliminar(int id)
        {
            var producto = ObtenerPorId(id);
            if (producto != null)
            {
                _productos.Remove(producto);
            }
        }
        private readonly IProductoRepository _productoRepo;

        
    }
}