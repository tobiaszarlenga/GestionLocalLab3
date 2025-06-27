using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioLocalLab3.Desktop.Models
{

    public class VentaReporte
    {
        public DateTime Fecha { get; set; }
        public string MetodoPago { get; set; } = string.Empty;
        public decimal MontoTotal { get; set; }
    }
}
