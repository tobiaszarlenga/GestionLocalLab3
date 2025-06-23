using GestioLocalLab3.API.Interface;

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


        [HttpGet("DelDia")]
        public IActionResult GetVentasDelDia(int mes, int dia)
        {
            var ventas = _ventaRepo.ObtenerTodas()
                .Where(v => v.Fecha.Month == mes && v.Fecha.Day == dia)
                .ToList();

            var totalEfectivo = ventas
                .Where(v => v.MetodoPago.ToLower() == "efectivo")
                .Sum(v => v.MontoTotal);

            var totalTransferencia = ventas
                .Where(v => v.MetodoPago.ToLower() == "transferencia")
                .Sum(v => v.MontoTotal);

            var resumen = new
            {
                CantidadVentas = ventas.Count,
                TotalGeneral = ventas.Sum(v => v.MontoTotal),
                TotalEfectivo = totalEfectivo,
                TotalTransferencia = totalTransferencia
            };

            return Ok(resumen);
        }

        [HttpGet("Mensual")]
        public IActionResult GetVentasDelMes(int mes)
        {
            var ventas = _ventaRepo.ObtenerTodas()
                .Where(v => v.Fecha.Month == mes)
                .ToList();

            var totalEfectivo = ventas
                .Where(v => v.MetodoPago.ToLower() == "efectivo")
                .Sum(v => v.MontoTotal);

            var totalTransferencia = ventas
                .Where(v => v.MetodoPago.ToLower() == "transferencia")
                .Sum(v => v.MontoTotal);

            var resumen = new
            {
                CantidadVentas = ventas.Count,
                TotalGeneral = ventas.Sum(v => v.MontoTotal),
                TotalEfectivo = totalEfectivo,
                TotalTransferencia = totalTransferencia
            };

            return Ok(resumen);
        }


    }
}
