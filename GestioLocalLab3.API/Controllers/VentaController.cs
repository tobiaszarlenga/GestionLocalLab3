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
        private readonly IProductoRepository _productoRepo;

        public VentaController(IVentaRepository ventaRepo, IProductoRepository productoRepo)
        {
            _ventaRepo = ventaRepo;
            _productoRepo = productoRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_ventaRepo.ObtenerTodas());
        }
        [HttpPost]
        public IActionResult Post([FromBody] Venta venta)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                _ventaRepo.Agregar(venta);
                return Ok("Venta registrada correctamente.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error al registrar venta: {ex.Message}");
            }
        }
        [HttpGet("reporte")]
        public IActionResult GetReporte()
        {
            var ventas = _ventaRepo.ObtenerTodas();

            var reporte = ventas
                .SelectMany(v => v.Detalles.Select(d => new VentaReporteDto
                {
                    VentaId = v.Id,
                    NombreProducto = d.Producto.Nombre,
                    Cantidad = d.Cantidad,
                    PrecioUnitario = d.PrecioUnitario
                }))
                .ToList();

            return Ok(reporte);
        }


    }
}
