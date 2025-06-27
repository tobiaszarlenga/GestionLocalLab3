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
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnGuardarProducto_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre.");
                return;
            }

            if (nudPrecio.Value <= 0)
            {
                MessageBox.Show("Debe ingresar un precio mayor a cero.");
                return;
            }



            var nuevoProducto = new Producto
            {
                Id = _productoAEditar?.Id ?? 0,
                Nombre = txtNombre.Text,
                Talle = txtTalle.Text,
                Precio = nudPrecio.Value,
                StockActual = (int)nudStockActual.Value
            };

            try
            {
                using var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7096/");

                HttpResponseMessage response;

                if (_productoAEditar == null)
                {
                    // ES NUEVO → POST
                    response = await client.PostAsJsonAsync("api/Producto", nuevoProducto);
                }
                else
                {
                    // ES EDICIÓN → PUT
                    response = await client.PutAsJsonAsync($"api/Producto/{nuevoProducto.Id}", nuevoProducto);
                }

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto guardado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private Producto? _productoAEditar;

        public FormProducto(Producto producto) : this()
        {
            _productoAEditar = producto;

            txtNombre.Text = producto.Nombre;
            txtTalle.Text = producto.Talle;
            nudPrecio.Value = producto.Precio;
            nudStockActual.Value = producto.StockActual;
        }


    }
}
