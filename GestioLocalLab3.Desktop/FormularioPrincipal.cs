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
            ProductoID = producto.Id,
            Producto = producto,
            Cantidad = (int)nudCantidad.Value,
            PrecioUnitario = producto.Precio
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
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al registrar venta: " + error);
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
            await CargarProductosAsync();
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
            await CargarProductosAsync();
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
                    await CargarProductosAsync();
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


        private async Task CargarVentasHoy()
        {
            try
            {
                using var client = new HttpClient();
                var ventas = await client.GetFromJsonAsync<List<DetalleVentaDto>>(
                    "https://localhost:7096/api/Reporte/Diario"
                );

                dgvReporte.DataSource = ventas;

                // Solo agregar columna si no existe
                if (!dgvReporte.Columns.Contains("PrecioUnitario"))
                {
                    dgvReporte.Columns.Add("PrecioUnitario", "Precio Unitario");
                    dgvReporte.Columns["PrecioUnitario"].DataPropertyName = "PrecioUnitario";
                }

                decimal total = 0;

                foreach (DataGridViewRow row in dgvReporte.Rows)
                {
                    if (row.DataBoundItem is DetalleVentaDto detalle)
                    {
                        total += detalle.PrecioUnitario * detalle.Cantidad;
                    }
                }

                lblTotalVentas.Text = $"Total del dia: ${total:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas del mes: " + ex.Message);
            }
        }


        private async Task CargarVentasMes()
        {
            try
            {
                using var client = new HttpClient();
                var ventas = await client.GetFromJsonAsync<List<DetalleVentaDto>>(
                    "https://localhost:7096/api/Reporte/Mensual"
                );

                dgvReporte.DataSource = ventas;

                // Solo agregar columna si no existe
                if (!dgvReporte.Columns.Contains("PrecioUnitario"))
                {
                    dgvReporte.Columns.Add("PrecioUnitario", "Precio Unitario");
                    dgvReporte.Columns["PrecioUnitario"].DataPropertyName = "PrecioUnitario";
                }

                decimal total = 0;

                foreach (DataGridViewRow row in dgvReporte.Rows)
                {
                    if (row.DataBoundItem is DetalleVentaDto detalle)
                    {
                        total += detalle.PrecioUnitario * detalle.Cantidad;
                    }
                }

                lblTotalVentas.Text = $"Total del mes: ${total:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ventas del mes: " + ex.Message);
            }
        }


        private async void btnVentasDia_Click(object sender, EventArgs e)
        {
            await CargarVentasMes();
        }

        private async void btnVentasMes_Click(object sender, EventArgs e)
        {
            await CargarVentasHoy();
        }

        private void btnEditarVenta_Click(object sender, EventArgs e)
        {

        }
    }
}
