using GestioLocalLab3.API.Models;

namespace GestioLocalLab3.API.Interface
{
    public class IProductoRepository
    {
        List<Producto> ObtenerTodos();
        Producto? ObtenerPorId(int id);
        void Agregar(Producto producto);
        void Actualizar(Producto producto);
        void Eliminar(int id);
    }
}
