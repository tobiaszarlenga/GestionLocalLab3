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
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {

            var usuario = new
            {
                nombre = txtNombre.Text,
                password = txtPassword.Text
            };

            try
            {
                var  httpClient = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:7138/")
                };

                var response = await httpClient.PostAsJsonAsync("api/Usuario/Register", usuario);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuario registrado con éxito");
                    this.Close();
                }
                else
                {
                    var error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error: " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }
    }
}
