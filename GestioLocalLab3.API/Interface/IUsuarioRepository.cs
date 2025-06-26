using GestioLocalLab3.API.Models;


namespace GestionLocalLab3.API.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario? ObtenerPorNombre(string nombre);
        void Registrar(Usuario usuario);
        bool ValidarCredenciales(string nombre, string password);
        List<Usuario> ObtenerTodos();
    }
}

