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
    }
}
