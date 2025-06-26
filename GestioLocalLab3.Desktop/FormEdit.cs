using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using GestioLocalLab3.Desktop.Models;


namespace GestioLocalLab3.Desktop
{
    public partial class FormEditarProducto : Form
    {
        private Producto producto;
        private bool esNuevo = false;
        public FormEditarProducto(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            esNuevo = false;

            txtNombre.Text = producto.Nombre;
            txtPrecio.Text = producto.Precio.ToString();
            txtStock.Text = producto.StockActual.ToString();
            txtTalle.Text = producto.Talle;

        }
        public Producto ProductoEditado => producto;
        public FormEditarProducto()
        {
  
            InitializeComponent();
            producto = new Producto(); 
            esNuevo = true;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        public virtual void Limpiar(object[] controles)
        {

            foreach (var control in controles)
            {
                if (control is TextBox)
                {
                    if (!string.IsNullOrEmpty(((TextBox)control).Text))
                    {
                        ((TextBox)control).Text = string.Empty;
                    }
                }
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar(new object[] { txtNombre, txtTalle, txtPrecio, txtStock });
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // ✅ Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtTalle.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Por favor, completá todos los campos.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("El stock debe ser un número entero válido.");
                return;
            }

            producto.Nombre = txtNombre.Text.Trim();
            producto.Talle = txtTalle.Text.Trim();
            producto.Precio = precio;
            producto.StockActual = stock;

            using HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:7096/") };

            try
            {
                HttpResponseMessage response;

                if (producto.Id == 0) // Producto nuevo
                    response = await client.PostAsJsonAsync("api/Producto", producto);
                else // Producto existente
                    response = await client.PutAsJsonAsync($"api/Producto/{producto.Id}", producto);

                if (response.IsSuccessStatusCode)
                {
                    string mensaje = producto.Id == 0 ? "Producto agregado correctamente." : "Producto actualizado correctamente.";
                    MessageBox.Show(mensaje, "Éxito");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error en la operación:\n{error}", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fallo de conexión:\n{ex.Message}", "Error");
            }
        }
    }
}
