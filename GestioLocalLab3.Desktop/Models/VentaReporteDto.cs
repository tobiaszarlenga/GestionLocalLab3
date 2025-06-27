﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioLocalLab3.Desktop.Models
{
    internal class VentaReporteDto
    {
        public int VentaId { get; set; }
        public string? NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
