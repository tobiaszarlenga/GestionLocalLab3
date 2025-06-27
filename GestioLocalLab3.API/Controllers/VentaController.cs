using GestioLocalLab3.API.Interface;
using GestioLocalLab3.API.Models;
using GestioLocalLab3.API.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace GestioLocalLab3.API.Controllers
{
        [ApiController]
        [Route("api/[controller]")]
        public class VentaController : ControllerBase
        {
        private readonly IVentaRepository _ventaRepo;
        private readonly IProductoRepository _productoRepo;

        public VentaController(
            IVentaRepository ventaRepo,
            IProductoRepository productoRepo)
        {
            _ventaRepo = ventaRepo;
            _productoRepo = productoRepo;
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
        [HttpGet("detalle")]
        public ActionResult<IEnumerable<DetalleVentaDto>> GetDetalleVentas()
        {
            var ventas = _ventaRepo.ObtenerTodas();
            var resultado = ventas.SelectMany(v => v.Detalles.Select(d => new DetalleVentaDto
            {
                NombreProducto = d.Producto?.Nombre ?? "",
                Cantidad = d.Cantidad,
                ModoPago = v.MetodoPago,
                Fecha = v.Fecha,
                PrecioUnitario = d.PrecioUnitario
            }));
            return Ok(resultado);
        }


        [HttpPost]
        public IActionResult Post([FromBody] Venta venta)
        {
            foreach (var detalle in venta.Detalles)
            {
                var producto = _productoRepo.ObtenerPorId(detalle.ProductoID);

                if (producto == null)
                    return BadRequest($"Producto con Id {detalle.ProductoID} no existe.");

                if (producto.StockActual < detalle.Cantidad)
                    return BadRequest($"Stock insuficiente para el producto {producto.Nombre}. "
                                     + $"Stock disponible: {producto.StockActual}.");
            }

            _ventaRepo.Agregar(venta);

            return CreatedAtAction(nameof(Get), new { id = venta.Id }, venta);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] DetalleVentaDto detalleDto)
        {
            var venta = _ventaRepo.ObtenerPorId(id);
            if (venta == null)
                return NotFound();

            // Buscar el detalle correcto por su ID
            var detalle = venta.Detalles.FirstOrDefault(d => d.ID == detalleDto.ID);
            if (detalle == null)
                return NotFound();

            detalle.Cantidad = detalleDto.Cantidad;
            detalle.PrecioUnitario = detalleDto.PrecioUnitario;
            detalle.ModoPago = detalleDto.ModoPago;

            return Ok(detalleDto);
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
        