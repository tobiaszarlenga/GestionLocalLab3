using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioLocalLab3.Desktop.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        public string? Talle { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int StockActual { get; set; }
        //public int Stock { get; set; }
    }
}
