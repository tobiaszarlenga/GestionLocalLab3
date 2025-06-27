using GestioLocalLab3.API.Models;
using GestionLocalLab3.API.Data;
using GestioLocalLab3.API.Interface;
using GestionLocalLab3.API.Interfaces;

using Microsoft.EntityFrameworkCore;

namespace GestionLocalLab3.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _context;

        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public Usuario? ObtenerPorNombre(string nombre)
        {
            return _context.Usuarios
                .FirstOrDefault(u => u.Nombre == nombre);
        }

        public void Registrar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public bool ValidarCredenciales(string nombre, string password)
        {
            return _context.Usuarios
                .Any(u => u.Nombre == nombre && u.Password == password);
        }

        public List<Usuario> ObtenerTodos()
        {
            return _context.Usuarios.ToList();
        }
    }
}
