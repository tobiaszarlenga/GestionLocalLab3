﻿namespace GestioLocalLab3.API.Models
{
    public class DetalleVentaDto
    {
        public string? NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public string? ModoPago { get; set; }
        public DateTime Fecha { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int VentaId { get; set; }
        public int ID { get; set; }

    }
}
