using GestioLocalLab3.API.Models;

namespace GestioLocalLab3.API.Interface
{
    public interface IUsuarioService
    {

        bool Registrar(Usuario usuario, out string error);
        bool Login(string nombre, string password);
    }
}
