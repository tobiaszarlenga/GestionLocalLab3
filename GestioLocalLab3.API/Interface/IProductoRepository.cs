using GestioLocalLab3.API.Models;
using System.Collections.Generic;

namespace GestioLocalLab3.API.Interface
{
    public interface IProductoRepository
    {
        List<Producto> ObtenerTodos();
        Producto? ObtenerPorId(int id);
        void Agregar(Producto producto);
        void Actualizar(Producto producto);
        void Eliminar(int id);
    }
}
