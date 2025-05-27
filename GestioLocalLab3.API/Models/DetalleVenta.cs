namespace GestioLocalLab3.API.Models
{
    public class DetalleVenta
    {
        public int ID { get; set; }
        public int VentaId { get; set; }
        public Venta Venta { get; set; }
        public int ProductoID { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

    }
}
