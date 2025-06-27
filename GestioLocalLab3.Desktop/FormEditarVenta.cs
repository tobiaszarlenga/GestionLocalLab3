using GestioLocalLab3.Desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioLocalLab3.Desktop
{
    public partial class FormEditarVenta : Form
    {
        public DetalleVentaDto VentaEditada { get; private set; }

        public FormEditarVenta(DetalleVentaDto detalle)
        {
            InitializeComponent();

            // Cargar datos en controles
            txtProducto.Text = detalle.NombreProducto;
            nudCantidad.Value = detalle.Cantidad;
            nudPrecio.Value = detalle.PrecioUnitario;
            cboModoPago.SelectedItem = detalle.ModoPago;
            VentaEditada.VentaId = detalle.VentaId;


            VentaEditada = detalle;
        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            VentaEditada.Cantidad = (int)nudCantidad.Value;
            VentaEditada.PrecioUnitario = nudPrecio.Value;
            VentaEditada.ModoPago = cboModoPago.SelectedItem?.ToString();

            using var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7096/");

            var response = await client.PutAsJsonAsync($"api/Venta/{VentaEditada.VentaId}", VentaEditada);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("¡Venta actualizada!");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                var error = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Error al editar venta: " + error);
            }
            MessageBox.Show("Venta editada correctamente.");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

    }
}
