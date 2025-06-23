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
            try
            {
                _ventaRepo.Agregar(venta);
                return CreatedAtAction(nameof(Get), new { id = venta.Id }, venta);
            }
            catch (InvalidOperationException ex)
            {
                // Esto captura cuando no hay suficiente stock u otro error esperado
                return BadRequest(new { mensaje = ex.Message });
            }
            catch (Exception ex)
            {
                // Esto captura errores inesperados
                return StatusCode(500, new { mensaje = "Ocurrió un error al registrar la venta", detalle = ex.Message });
            }
        }

    }
}
        