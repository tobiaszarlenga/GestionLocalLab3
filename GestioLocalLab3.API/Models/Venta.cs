namespace GestioLocalLab3.API.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal MontoTotal { get; set; }
        public string MetodoPago { get; set; } = string.Empty;

        public ICollection <DetalleVenta> Detalles { get; set; } =new List<DetalleVenta>();

    }
}
