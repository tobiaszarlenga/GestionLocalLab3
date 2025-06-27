using GestioLocalLab3.API.Models;

namespace GestioLocalLab3.API.Interface
{
    public interface IVentaRepository
    {
        void Agregar(Venta venta);
        void Editar(Venta venta);
        void Eliminar(int ventaId);
        List<Venta> ObtenerTodas();
        Venta? ObtenerPorId(int id);

    }
}
