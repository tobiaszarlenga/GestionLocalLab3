﻿namespace GestioLocalLab3.API.Models
{
    public class Usuario
    {

        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
