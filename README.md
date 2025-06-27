# GestioLocalLab3

Sistema de gestión para un local de artículos deportivos, desarrollado como proyecto académico en .NET 8. Permite administrar ventas, stock y reportes, integrando un backend API RESTful y un frontend de escritorio en WinForms.

---

## 🚀 Tecnologías Utilizadas

- **.NET 8 (ASP.NET Core Web API)**
- **WinForms (.NET 8)**
- **Entity Framework Core**
- **SQL Server**
- **C#**
- **Swagger / Postman** para pruebas de API

---

## 📂 Estructura del Proyecto


```text
GestionLocalLab3
│
├── GestionLocalLab3.API
│   ├── Controllers
│   ├── Models
│   ├── Repositories
│   ├── Services
│   └── Migrations
│
└── GestionLocalLab3.Desktop
    ├── Models
    ├── Formularios (WinForms)
    └── Program.cs
```





---

## ⚙️ Funcionalidades

### 🔒 Autenticación

- Registro de usuario (nombre y contraseña).
- Login de usuario.
- Mantenimiento de sesión activa.

### 🛒 Gestión de Ventas

- Registrar una nueva venta.
- Seleccionar producto y talle.
- Ingresar cantidad.
- Actualización automática de stock.
- Visualización de detalles de ventas en un `DataGridView`.
- Editar o eliminar ventas.

### 📦 Gestión de Stock

- Visualizar listado de productos.
- Modificar stock disponible.
- Alta, baja y modificación de productos.

### 📊 Reporte

- Visualización de reportes de ventas.
- Filtrado por día, mes o rango de fechas.
- Totales de ventas (cantidad y monto).

---

## 🔗 Arquitectura

El proyecto sigue principios SOLID:

- **Single Responsibility:** Clases separadas para controladores, servicios y repositorios.
- **Dependency Injection:** Repositorios y servicios inyectados en los controladores.
- **DTOs (Data Transfer Objects):** Separación entre entidades de dominio y objetos de transporte.

---

## 🗄️ Base de Datos

- **Motor:** SQL Server
- **ORM:** Entity Framework Core
- **Migraciones:** Usadas para versionar la estructura de tablas.
- Entidades principales:
  - Usuario
  - Producto
  - Venta
  - DetalleVenta

---

## 💻 WinForms Frontend

- Diseño por tabs: VENTAS, STOCK, REPORTE.
- Formularios independientes para:
  - Login
  - Registro
  - Edición de ventas
- Consumo de API mediante **HttpClient**.

---

## 🔥 Cómo Ejecutar el Proyecto

### 1. Clonar el Repositorio

```bash
git clone https://github.com/tuusuario/GestioLocalLab3.git

```
2. Configurar la Base de Datos
Crear una base en SQL Server.

Modificar el appsettings.json:
"ConnectionStrings": {
  "DefaultConnection": "Server=TU_SERVER;Database=GestioLocalLab3;Trusted_Connection=True;TrustServerCertificate=True;"
}
3. Ejecutar Migraciones
Desde el directorio API:
dotnet ef database update
4. Ejecutar la API
dotnet run --project GestionLocalLab3.API
API disponible en:
https://localhost:7096/swagger
5. Ejecutar WinForms
Establecer proyecto GestionLocalLab3.Desktop como proyecto de inicio.

Ejecutar (F5 o Ctrl + F5).
🛠️ Endpoints Principales
Usuarios

POST /api/Usuario/login

POST /api/Usuario/register

Productos

GET /api/Producto

POST /api/Producto

PUT /api/Producto/{id}

DELETE /api/Producto/{id}

Ventas

GET /api/Venta

POST /api/Venta

PUT /api/Venta/{id}

DELETE /api/Venta/{id}

DIAGRAMA DE ARQUITECTURA
https://drive.google.com/file/d/1Ja22Mknk2pQev6FdVeSXNJkEsvFdh7fq/view?usp=sharing
MANUAL DE USUARIO
https://docs.google.com/presentation/d/12OB78s81QS_XYI8BXDNF1CoEWIYeFhRz/edit?usp=sharing&ouid=101517266477648166811&rtpof=true&sd=true

👨‍💻 Autor
Tobias Zarlenga
Aitana Molina
Pablo Gramajo
Santiago perez
mariano achi

Proyecto académico Facultad

