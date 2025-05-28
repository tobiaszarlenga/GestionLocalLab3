namespace GestioLocalLab3.API.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Talle { get; set; } = string.Empty;
        public decimal Precio {  get; set; } 
        public int StockActual { get; set; }

    }
}
