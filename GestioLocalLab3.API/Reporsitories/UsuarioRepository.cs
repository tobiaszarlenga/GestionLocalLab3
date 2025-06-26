using GestioLocalLab3.API.Interface;
using GestioLocalLab3.API.Models;
using GestionLocalLab3.API.Interfaces;


namespace GestionLocalLab3.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly List<Usuario> _usuarios = new();
        private int _nextId = 1;

        public Usuario? ObtenerPorNombre(string nombre)
        {
            return _usuarios.FirstOrDefault(u =>
                u.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
        }

        public void Registrar(Usuario usuario)
        {
            usuario.Id = _nextId++;
            _usuarios.Add(usuario);
        }

        public bool ValidarCredenciales(string nombre, string password)
        {
            return _usuarios.Any(u => u.Nombre == nombre && u.Password == password);
        }

        public List<Usuario> ObtenerTodos()
        {
            return _usuarios;
        }
    }
}
