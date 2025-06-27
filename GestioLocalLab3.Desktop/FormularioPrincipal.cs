using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using GestioLocalLab3.Desktop.Models;


namespace GestioLocalLab3.Desktop
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }






        private async Task CargarProductosAsync()
        {
            try
            {
                using var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7096/");

                var productos = await client.GetFromJsonAsync<List<Producto>>("api/Producto");

                if (productos != null)
                {
                    cboProducto.DataSource = productos;
                    cboProducto.DisplayMember = "Nombre";
                    cboProducto.ValueMember = "Id";
                }
                else
                {
                    MessageBox.Show("No se pudieron cargar productos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private async void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            await CargarProductosAsync();

            cboModoPago.Items.Add("Efectivo");
            cboModoPago.Items.Add("Transferencia");
            cboModoPago.SelectedIndex = 0;
        }

        private async void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (cboProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un producto.");
                return;
            }

          
            var producto = cboProducto.SelectedItem as Producto;
            if (producto == null)
            {
                MessageBox.Show("Producto inválido.");
                return;
            }

            var nuevaVenta = new Venta
            {
                ProductoId = producto.Id,
                Cantidad = (int)nudCantidad.Value,
                ModoPago = cboModoPago.SelectedItem.ToString(),
                Fecha = DateTime.Now
            };

            try
            {
                using var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7096/");

                var response = await client.PostAsJsonAsync("api/Venta", nuevaVenta);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Venta registrada.");

                    await CargarVentasAsync();
                }
                else
                {
                    MessageBox.Show("Error al registrar venta: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async Task CargarVentasAsync()
        {
            try
            {
                using var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7096/");

                var ventas = await client.GetFromJsonAsync<List<Venta>>("api/Venta");

                if (ventas != null)
                {
                    dgvVentas.DataSource = ventas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message);
            }
        }

    }
}
