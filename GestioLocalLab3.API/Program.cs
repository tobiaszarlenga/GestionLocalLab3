using GestioLocalLab3.API.Interface;
using GestioLocalLab3.API.Models;
using GestioLocalLab3.API.Repositories;
using GestionLocalLab3.API.Interfaces;
using GestionLocalLab3.API.Repositories;
using GestionLocalLab3.API.Services;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Instanciar la lista única de productos
var productos = new List<Producto>
{
    new Producto { Id = 1, Nombre = "Remera", Talle = "M", Precio = 4500, StockActual = 10 },
    new Producto { Id = 2, Nombre = "Jean", Talle = "42", Precio = 12000, StockActual = 7 }
};

// Registrar repositorios y servicios
builder.Services.AddSingleton<IProductoRepository>(new ProductoRepository(productos));
builder.Services.AddSingleton<IVentaRepository>(new VentaRepository(productos));
builder.Services.AddSingleton<IUsuarioRepository, UsuarioRepository>(); // ? agregado
builder.Services.AddSingleton<IUsuarioService, UsuarioService>();

// Configuración básica
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
