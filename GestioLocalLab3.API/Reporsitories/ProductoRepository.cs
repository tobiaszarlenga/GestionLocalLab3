using GestioLocalLab3.API.Interface;
using GestionLocalLab3.API.Data;

using GestioLocalLab3.API.Models;

namespace GestionLocalLab3.API.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly AppDbContext _context;

        public ProductoRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Producto> ObtenerTodos()
        {
            return _context.Productos.ToList();
        }

        public Producto? ObtenerPorId(int id)
        {
            return _context.Productos.FirstOrDefault(p => p.Id == id);
        }

        public void Agregar(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void Actualizar(Producto producto)
        {
            _context.Productos.Update(producto);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var tieneDetalles = _context.DetallesVenta
                .Any(d => d.ProductoID == id);

            if (tieneDetalles)
                throw new Exception("No se puede eliminar el producto porque tiene ventas registradas.");

            var producto = _context.Productos.FirstOrDefault(p => p.Id == id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
            }
        }

    }
}
