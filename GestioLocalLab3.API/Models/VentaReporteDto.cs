namespace GestioLocalLab3.API.Models
{
    public class VentaReporteDto
    {
        public int VentaId { get; set; }
        public string? NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
