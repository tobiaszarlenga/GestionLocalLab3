using GestioLocalLab3.API.Interface;
using GestioLocalLab3.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionLocalLab3.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReporteController : ControllerBase
    {
        private readonly IVentaRepository _ventaRepo;

        public ReporteController(IVentaRepository ventaRepo)
        {
            _ventaRepo = ventaRepo;
        }


        [HttpGet("Diario")]
        public ActionResult<IEnumerable<DetalleVentaDto>> GetVentasDelDia()
        {
            var ventasHoy = _ventaRepo.ObtenerTodas()
                .Where(v => v.Fecha.Date == DateTime.Now.Date)
                .SelectMany(v => v.Detalles.Select(d => new DetalleVentaDto
                {
                    NombreProducto = d.Producto?.Nombre ?? "",
                    Cantidad = d.Cantidad,
                    ModoPago = v.MetodoPago,
                    Fecha = v.Fecha
                }))
                .ToList();

            return Ok(ventasHoy);
        }

        [HttpGet("Mensual")]
        public ActionResult<IEnumerable<DetalleVentaDto>> GetVentasDelMes()
        {
            var mesActual = DateTime.Now.Month;

            var ventasMes = _ventaRepo.ObtenerTodas()
                .Where(v => v.Fecha.Month == mesActual)
                .SelectMany(v => v.Detalles.Select(d => new DetalleVentaDto
                {
                    NombreProducto = d.Producto?.Nombre ?? "",
                    Cantidad = d.Cantidad,
                    ModoPago = v.MetodoPago,
                    Fecha = v.Fecha
                }))
                .ToList();

            return Ok(ventasMes);
        }


    }
}
