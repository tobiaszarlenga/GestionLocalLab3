using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioLocalLab3.Desktop.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string MetodoPago { get; set; }   
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();
    }

}
