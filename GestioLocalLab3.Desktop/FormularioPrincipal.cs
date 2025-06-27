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


    }
}
