using Microsoft.AspNetCore.Mvc;
using GestioLocalLab3.API.Interface;
using GestioLocalLab3.API.Models;

namespace GestionLocalLab3.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoRepository _repo;

        public ProductoController(IProductoRepository repo)
        {
            _repo = repo;
        }

        
        [HttpGet]
        public IActionResult Get()
        {
            var productos = _repo.ObtenerTodos();
            return Ok(productos);
        }

        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var producto = _repo.ObtenerPorId(id);
            if (producto == null) return NotFound();
            return Ok(producto);
        }

        
        [HttpPost]
        public IActionResult Post([FromBody] Producto producto)
        {
            _repo.Agregar(producto);
            return CreatedAtAction(nameof(Get), new { id = producto.Id }, producto);
        }

        
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Producto producto)
        {
            if (id != producto.Id) return BadRequest();
            _repo.Actualizar(producto);
            return NoContent();
        }

        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repo.Eliminar(id);
            return NoContent();
        }
    }
}