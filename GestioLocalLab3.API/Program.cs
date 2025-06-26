using GestioLocalLab3.API.Interface;
using GestionLocalLab3.API.Repositories;
using GestioLocalLab3.API.Models;        
using GestioLocalLab3.API.Repositories;
using GestionLocalLab3.API.Services;


var builder = WebApplication.CreateBuilder(args);

// Instanciar la lista única de productos
var productos = new List<Producto>
{
    new Producto { Id = 1, Nombre = "Remera", Talle = "M", Precio = 4500, StockActual = 10 },
    new Producto { Id = 2, Nombre = "Jean", Talle = "42", Precio = 12000, StockActual = 7 }
    // Agregá más productos si querés
};

// Registrar ambos repositorios usando la misma lista
builder.Services.AddSingleton<IProductoRepository>(new ProductoRepository(productos));
builder.Services.AddSingleton<IVentaRepository>(new VentaRepository(productos));

// El resto igual
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();

