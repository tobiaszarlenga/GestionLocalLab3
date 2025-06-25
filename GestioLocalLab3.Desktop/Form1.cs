using System.Net.Http.Json;
using GestioLocalLab3.Desktop.Models;

namespace GestioLocalLab3.Desktop
{
    public partial class Form1 : Form
    {
        private List<DetalleVenta> carrito = new();
        private int idProductoSeleccionado = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            cbMes.Items.AddRange(Enumerable.Range(1, 12).Select(i => i.ToString()).ToArray());
            cbMes.SelectedIndex = DateTime.Now.Month - 1;
            nudDia.Value = DateTime.Now.Day;
            nudDia.Minimum = 1;
            nudDia.Maximum = 31;

            cbMetodoPago.Items.AddRange(new[] { "Efectivo", "Transferencia" });
            cbMetodoPago.SelectedIndex = 0;

            ConfigurarGrillaCarrito();
            await CargarProductosAsync();

            nudPrecioProducto.DecimalPlaces = 2;
            nudPrecioProducto.Increment = 10;
            nudPrecioProducto.Maximum = 1000000;
            nudPrecioProducto.Minimum = 1;
        }

        //FUNCION ASYNCRONA PARA TRAER LA LISTA DE PRODUCTOS DE MI API REST USANDO HTTP
        private async Task<List<Producto>> ObtenerProductosAsync()
        {
            using HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:7096/") };
            var response = await client.GetAsync("api/Producto");

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Error al cargar productos: " + response.StatusCode);
                return new();
            }

            return await response.Content.ReadFromJsonAsync<List<Producto>>() ?? new();
        }


        //GRILLA DE PRODUCTOS
        private void ConfigurarGrillaCarrito()
        {
            dataGridViewCarrito.Columns.Clear();
            dataGridViewCarrito.Columns.Add("Producto", "Producto");
            dataGridViewCarrito.Columns.Add("Cantidad", "Cantidad");
            dataGridViewCarrito.Columns.Add("PrecioUnitario", "Precio Unitario");        
            dataGridViewCarrito.Columns.Add("Subtotal", "Subtotal");
            dataGridViewCarrito.Columns.Add("MetodoPago", "Método de Pago");
        }


        //EVENTO DEL BOTON "AGREGAR AL CARRITO"
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbProductos.SelectedItem is not Producto productoSeleccionado)
                return;

            int cantidad = (int)nudCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.");
                return;
            }

            if (cantidad > productoSeleccionado.StockActual)
            {
                MessageBox.Show($" No hay suficiente stock disponible.\nSolo quedan {productoSeleccionado.StockActual} unidades.");
                return;
            }

            var detalle = new DetalleVenta
            {
                ProductoID = productoSeleccionado.Id,
                Cantidad = cantidad,
                PrecioUnitario = productoSeleccionado.Precio,
                Producto = productoSeleccionado
            };

            carrito.Add(detalle);

            // Descontar del stock
            productoSeleccionado.StockActual -= cantidad;

            // Agregar a la grilla
            dataGridViewCarrito.Rows.Add(
                productoSeleccionado.Nombre,
                cantidad,
                productoSeleccionado.Precio.ToString("C"),
                (productoSeleccionado.Precio * cantidad).ToString("C"),
                cbMetodoPago.SelectedItem?.ToString()
            );

            nudCantidad.Value = 1;
            cbProductos.SelectedIndex = 0;
        }




        //METODO PARA ENVIAR TODO LO QUE HAY EN MI CARRITO (DATAGRIDVIEW) AL API (POST /api/venta)
        private async void btnRegistarVenta_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("El carrito está vacío.");
                return;
            }

            string metodoPago = cbMetodoPago.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(metodoPago))
            {
                MessageBox.Show("Seleccioná un método de pago.");
                return;
            }

            decimal montoTotal = carrito.Sum(d => d.Cantidad * d.PrecioUnitario);

            var venta = new Venta
            {
                Fecha = DateTime.Now,
                MetodoPago = metodoPago,
                MontoTotal = montoTotal,
                Detalles = carrito.Select(det => new DetalleVenta
                {
                    ProductoID = det.ProductoID,
                    Cantidad = det.Cantidad,
                    PrecioUnitario = det.PrecioUnitario,
                    Producto = new Producto { Id = det.ProductoID } 
                }).ToList()
            };

            using HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:7096/") };
            var response = await client.PostAsJsonAsync("api/Venta", venta);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Venta registrada correctamente.");
                carrito.Clear();
                dataGridViewCarrito.Rows.Clear();
                cbMetodoPago.SelectedIndex = 0;
                cbProductos.SelectedIndex = 0;
                nudCantidad.Value = 1;
            }
            else
            {
                string msg = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Error al registrar la venta:\n" + msg);
            }
        }
        //IGUAL NO FUNCIONA TODAVIA


        //CARGO PRODUCTOS EN EL DATAGRIDVIEW DE LA PESTAÑA STOCK
        private async void btnCargarProductos_Click(object sender, EventArgs e)
        {
            await CargarProductosEnGrilla();
        }

        //MUESTRA TODOS LOS PRODUCTOS EN EL DATA DE LA PESTAÑA STOCK
        private async Task CargarProductosEnGrilla()
        {
            var productos = await ObtenerProductosAsync();

            dataGridViewStock.Rows.Clear();
            dataGridViewStock.Columns.Clear();
            dataGridViewStock.Columns.Add("Id", "ID");
            dataGridViewStock.Columns.Add("Nombre", "Nombre");
            dataGridViewStock.Columns.Add("Precio", "Precio");
            dataGridViewStock.Columns.Add("Stock", "Stock");

            foreach (var p in productos)
            {
                dataGridViewStock.Rows.Add(p.Id, p.Nombre, p.Precio.ToString("C"), p.StockActual);
            }
        }

        //CARGA LOS PRODUCTOS EN EL COMBOBOX DE TAB VENTAS
        private async Task CargarProductosAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7096/"); // Verificá que Swagger esté corriendo

                HttpResponseMessage response = await client.GetAsync("api/Producto");

                if (response.IsSuccessStatusCode)
                {
                    var productos = await response.Content.ReadFromJsonAsync<List<Producto>>();

                    cbProductos.DataSource = productos;
                    cbProductos.DisplayMember = "Nombre";
                    cbProductos.ValueMember = "Id";
                }
                else
                {
                    MessageBox.Show("Error al cargar productos desde la API.");
                }
            }
        }
        

        //EVENTO DEL DATA DE MI TAB STOCK PARA EDITAR, ELIMINAR
        private void dataGridViewStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dataGridViewStock.Rows[e.RowIndex];
            idProductoSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
            txtNombreProducto.Text = fila.Cells["Nombre"].Value?.ToString();
            nudPrecioProducto.Value = decimal.Parse(fila.Cells["Precio"].Value?.ToString().Replace("$", ""));
            nudStockProducto.Value = Convert.ToInt32(fila.Cells["Stock"].Value);
        }


        //EVENTO PARA ELIMINAR UN PRODUCTO EN  TAB STOCK
        private async void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == -1)
            {
                MessageBox.Show("Seleccioná un producto primero.");
                return;
            }

            if (MessageBox.Show("¿Estás seguro de eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:7096/") };
            var response = await client.DeleteAsync($"api/Producto/{idProductoSeleccionado}");

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Producto eliminado.");
                idProductoSeleccionado = -1;
                await CargarProductosEnGrilla();
            }
            else
            {
                MessageBox.Show(" Error al eliminar: \n" + await response.Content.ReadAsStringAsync());
            }
        }

        //EVENTO PARA EDITAR UN PRODUCTO EN TAB STOCK
        private async void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == -1)
            {
                MessageBox.Show("Seleccioná un producto primero.");
                return;
            }

            string nombre = txtNombreProducto.Text.Trim();
            decimal precio = nudPrecioProducto.Value;
            int stock = (int)nudStockProducto.Value;

            if (string.IsNullOrWhiteSpace(nombre) || precio <= 0 || stock < 0)
            {
                MessageBox.Show("Completá todos los campos correctamente.");
                return;
            }

            var producto = new Producto { Id = idProductoSeleccionado, Nombre = nombre, Precio = precio, StockActual = stock };

            using HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:7096/") };
            var response = await client.PutAsJsonAsync($"api/Producto/{idProductoSeleccionado}", producto);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Producto editado.");
                idProductoSeleccionado = -1;
                txtNombreProducto.Clear();
                nudPrecioProducto.Value = nudPrecioProducto.Minimum; ;
                nudStockProducto.Value = nudStockProducto.Minimum;
                await CargarProductosEnGrilla();
            }
            else
            {
                MessageBox.Show("Error al editar: \n" + await response.Content.ReadAsStringAsync());
            }
        }

        //EVENTO PARA AGREGAR PRODUCTOS AL STOCK
        private async void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreProducto.Text.Trim();
            decimal precio = nudPrecioProducto.Value;
            int stock = (int)nudStockProducto.Value;

            if (string.IsNullOrWhiteSpace(nombre) || precio <= 0 || stock < 0)
            {
                MessageBox.Show("Completá correctamente todos los campos.");
                return;
            }

            var nuevoProducto = new Producto
            {
                Nombre = nombre,
                Precio = precio,
                StockActual = stock
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7096/");
                var response = await client.PostAsJsonAsync("api/Producto", nuevoProducto);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto agregado correctamente.");
                    await CargarProductosEnGrilla();
                    txtNombreProducto.Clear();
                    nudPrecioProducto.Value = nudPrecioProducto.Minimum;
                    nudStockProducto.Value = nudStockProducto.Minimum;
                }
                else
                {
                    string msg = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error al agregar producto:\n" + msg);
                }
            }
        }

        //EVENTO DEL BOTON "CARGAR PRODUCTO" PARA LLENAR EL COMBOBOX CON LOS PRODUCTOS TRAIDOS DE LA API 
        private async void btnCargarProducto_Click(object sender, EventArgs e)
        {

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7096/");

                HttpResponseMessage response = await client.GetAsync("api/Producto");

                if (response.IsSuccessStatusCode)
                {
                    var productos = await response.Content.ReadFromJsonAsync<List<Producto>>();

                    cbProductos.DataSource = productos;
                    cbProductos.DisplayMember = "Nombre";
                    cbProductos.ValueMember = "Id";
                }
                else
                {
                    MessageBox.Show("Error al cargar productos desde la API.");
                }
            }
        }

        //SE EJECUTA
        private void nudPrecioProducto_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void btnVerReporte_Click(object sender, EventArgs e)
        {
            if (cbMes.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná un mes.");
                return;
            }

            int mes = int.Parse(cbMes.SelectedItem.ToString());
            int dia = (int)nudDia.Value;

            using HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:7096/") };
            var response = await client.GetAsync($"api/Reporte/Mensual?mes={mes}&dia={dia}");

            if (response.IsSuccessStatusCode)
            {
                var resumen = await response.Content.ReadFromJsonAsync<ResumenVenta>();

                lblTotalMes.Text = $"Ventas: {resumen.CantidadVentas}\n" +
                                   $"Total: {resumen.TotalGeneral:C}\n" +
                                   $"Efectivo: {resumen.TotalEfectivo:C}\n" +
                                   $"Transferencia: {resumen.TotalTransferencia:C}";
            }
            else
            {
                MessageBox.Show("Error al obtener el resumen:\n" + await response.Content.ReadAsStringAsync());
            }

        }





        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            
        }

        private void tabReporte_Click(object sender, EventArgs e)
        {
           
        }

        private void tabVenta_Click(object sender, EventArgs e)
        {
        }


        

        private void dataGridViewCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


