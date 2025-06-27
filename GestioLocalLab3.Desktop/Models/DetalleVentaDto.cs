using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioLocalLab3.Desktop.Models
{
    
        public class DetalleVentaDto
        {
            public string? NombreProducto { get; set; }
            public int Cantidad { get; set; }
            public string? ModoPago { get; set; }
            public DateTime Fecha { get; set; }
            public decimal PrecioUnitario { get; set; }
            public int VentaId { get; set; }

    }


}
