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
            _ventas.Add(venta);
        }
    }
}