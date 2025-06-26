using GestioLocalLab3.API.Interface;
using GestioLocalLab3.API.Models;
using GestionLocalLab3.API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestionLocalLab3.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] Usuario usuario)
        {
            if (_service.Registrar(usuario, out string error))
                return Ok("Usuario registrado correctamente.");

            return BadRequest(error);
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] Usuario usuario)
        {
            if (_service.Login(usuario.Nombre, usuario.Password))
                return Ok("Inicio de sesión exitoso.");

            return Unauthorized("Credenciales inválidas.");
        }
    }
}
