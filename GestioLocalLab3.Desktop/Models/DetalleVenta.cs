using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioLocalLab3.Desktop.Models
{
    public class DetalleVenta
    {

        public int ProductoID { get; set; }

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public Venta Venta { get; set; }
        public Producto? Producto { get; set; }
    }

}
