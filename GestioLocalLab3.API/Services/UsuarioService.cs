using GestioLocalLab3.API.Interface;
using GestioLocalLab3.API.Models;
using GestionLocalLab3.API.Interfaces;

namespace GestionLocalLab3.API.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repo;

        public UsuarioService(IUsuarioRepository repo)
        {
            _repo = repo;
        }

        public bool Registrar(Usuario usuario, out string error)
        {
            error = string.Empty;
            if (_repo.ObtenerPorNombre(usuario.Nombre) != null)
            {
                error = "El nombre de usuario ya está en uso.";
                return false;
            }

            _repo.Registrar(usuario);
            return true;
        }

        public bool Login(string nombre, string password)
        {
            return _repo.ValidarCredenciales(nombre, password);
        }
    }
}
