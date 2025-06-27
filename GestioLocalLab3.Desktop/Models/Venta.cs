using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioLocalLab3.Desktop.Models
{
    public class Venta
    {
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public string? ModoPago { get; set; }
        public DateTime Fecha { get; set; }
    }

}
