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
using static System.Collections.Specialized.BitVector32;

namespace GestioLocalLab3.Desktop
{
    public partial class FormLogin : Form
    {

        private readonly HttpClient _httpClient;

        public FormLogin()
        {
            InitializeComponent();
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7138/")
            };
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var usuario = new
            {
                nombre = txtNombre.Text,
                password = txtPassword.Text
            };

            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/Usuario/Login", usuario);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Inicio de sesión exitoso");

                    // Opcional: guardar usuario en clase Sesion
                    Sesion.UsuarioNombre = usuario.nombre;

                    // Abrir pantalla principal y cerrar login
                    this.Hide();
                    new Form1().Show(); // tu menú principal
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

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            new FormRegistro().ShowDialog();
        }
    }
}
