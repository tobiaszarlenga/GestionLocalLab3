using GestioLocalLab3.API.Interface;
using GestioLocalLab3.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestioLocalLab3.API.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class VentaController : ControllerBase
        {
            private readonly IVentaRepository _ventaRepo;

            public VentaController(IVentaRepository ventaRepo)
            {
                _ventaRepo = ventaRepo;
            }

            [HttpGet]
            public IActionResult Get()
            {
                return Ok(_ventaRepo.ObtenerTodas());
            }

            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var venta = _ventaRepo.ObtenerPorId(id);
                if (venta == null) return NotFound();
                return Ok(venta);

            }
        [HttpPost]
        public IActionResult Post([FromBody] Venta venta)
        {
            _ventaRepo.Agregar(venta);
            return CreatedAtAction(nameof(Get), new { id = venta.Id }, venta);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Venta venta)
        {
            try
            {
                venta.Id = id;
                _ventaRepo.Editar(venta);
                return Ok(venta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _ventaRepo.Eliminar(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
        