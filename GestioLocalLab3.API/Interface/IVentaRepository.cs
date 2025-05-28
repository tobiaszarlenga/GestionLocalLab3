using GestioLocalLab3.API.Models;

namespace GestioLocalLab3.API.Interface
{
    public interface IVentaRepository
    {
        List<Venta> ObtenerTodas();
        Venta? ObtenerPorId(int id);
        void Agregar(Venta venta);
    }
}
