using GestioLocalLab3.API.Interface;
using GestioLocalLab3.API.Models;


namespace GestionLocalLab3.API.Repositories
{
    public class VentaRepository : IVentaRepository
    {
        private readonly List<Venta> _ventas = new();
        private int _nextId = 1;

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
            venta.Id = _nextId++;
            venta.Fecha = DateTime.Now;
            venta.MontoTotal = venta.Detalles.Sum(d => d.Cantidad * d.PrecioUnitario);
            foreach (var detalle in venta.Detalles)
            {
                var producto = _productoRepo.ObtenerPorId(detalle.ProductoID);
                if (producto != null)
                {
                    if (producto.StockActual >= detalle.Cantidad)
                    {
                        producto.StockActual -= detalle.Cantidad;
                        _productoRepo.Actualizar(producto);
                    }
                    else
                    {
                        throw new InvalidOperationException($"No hay suficiente stock para el producto '{producto.Nombre}'");
                    }
                }
            }
                _ventas.Add(venta);
        }
        private readonly IProductoRepository _productoRepo;

        public VentaRepository(IProductoRepository productoRepo)
        {
            _productoRepo = productoRepo;
        }
    }
}