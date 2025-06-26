using GestioLocalLab3.API.Interface;
using GestionLocalLab3.API.Interfaces;
using GestionLocalLab3.API.Repositories;
using GestionLocalLab3.API.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IProductoRepository, ProductoRepository>();
builder.Services.AddSingleton<IVentaRepository, VentaRepository>();
builder.Services.AddSingleton<IUsuarioRepository, UsuarioRepository>(); ;
builder.Services.AddSingleton<IUsuarioService, UsuarioService>(); // ? nuevo

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
