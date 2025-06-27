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






        private async Task CargarProductosAsync(DataGridView? grid = null)
        {
            try
            {
                using var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7096/");

                var productos = await client.GetFromJsonAsync<List<Producto>>("api/Producto");

                if (productos != null)
                {
                    // Si viene un DataGridView, lo lleno
                    if (grid != null)
                    {
                        grid.DataSource = productos;
                    }
                    else
                    {
                        cboProducto.DataSource = productos;
                        cboProducto.DisplayMember = "Nombre";
                        cboProducto.ValueMember = "Id";
                    }
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
            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.");
                return;
            }


            var nuevaVenta = new Venta
            {
                MetodoPago = cboModoPago.SelectedItem.ToString(),
                Fecha = DateTime.Now,
                Detalles = new List<DetalleVenta>
           {
             new DetalleVenta
         {
                    ProductoId = producto.Id,
                     Producto = producto, // Esto es útil para mostrar el nombre
                    Cantidad = (int)nudCantidad.Value
        }
    }
            };


            try
            {
                using var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7096/");

                var response = await client.PostAsJsonAsync("api/Venta", nuevaVenta);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Venta registrada.");
                    await CargarVentas();
                    cboProducto.SelectedIndex = 0;
                    cboModoPago.SelectedIndex = 0;
                    nudCantidad.Value = 1;



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



        private async Task CargarVentas()
        {
            try
            {
                var client = new HttpClient();
                var ventas = await client.GetFromJsonAsync<List<DetalleVentaDto>>("https://localhost:7096/api/Venta/detalle");
                dgvVentas.DataSource = ventas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas: " + ex.Message);
            }
            await CargarProductosAsync(dgvProductos);
        }

        private async void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            var formProducto = new FormProducto();
            formProducto.ShowDialog();

            // Recargar productos
            await CargarProductosAsync(dgvProductos);
        }

        private async void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un producto para editar.");
                return;
            }

            var producto = (Producto)dgvProductos.CurrentRow.DataBoundItem;

            var formProducto = new FormProducto(producto);
            formProducto.ShowDialog();

            // Al volver, recargar productos
            await CargarProductosAsync(dgvProductos);
        }

        private async void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccioná un producto para eliminar.");
                return;
            }

            var producto = (Producto)dgvProductos.CurrentRow.DataBoundItem;

            var confirmar = MessageBox.Show(
                $"¿Seguro que querés eliminar el producto '{producto.Nombre}'?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmar != DialogResult.Yes)
                return;

            try
            {
                using var client = new HttpClient();
                client.BaseAddress = new Uri("https://localhost:7096/");

                var response = await client.DeleteAsync($"api/Producto/{producto.Id}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto eliminado correctamente.");
                    await CargarProductosAsync(dgvProductos);
                }
                else
                {
                    MessageBox.Show("Error al eliminar: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
