# 🎬 Movie API 🌟

¡Bienvenido a la API de base de datos de películas! Esta API está construida en .NET 8 y diseñada para alimentar un
sitio de películas con toda la información que necesitas sobre tus filmes favoritos. 🚀

## 🚀 Tecnologías

- .NET 8
- Entity Framework Core
- SQL Server

## 🌐 Endpoints

### 📋 Películas

- **POST /api/Historial/agregar**
- **GET /api/peliculas**

### 🌟 Usuarios

- **POST /api/registro**
- **POST /api/auth/login**
- **POST /api/auth/logout**

## 🛠 Configuración

1. Clona este repositorio:
   ```bash
   git https://github.com/Ramiro-Zein/API-PELICULAS.git

2. Configura la base de datos en appsettings.json.
   ```bash
   "ConnectionStrings": {
       "DefaultConnection": "Server=servername;Database=databasename;User ID=name;Password=1234;TrustServerCertificate=True;Connection Timeout=30;"
   }

3. Aplica las migraciones de EF Core
   ```bash
   dotnet ef database update

4. Ejecuta el proyecto
   ```bash
   dotnet run

🧪Pruebas

```bash
   dotnet test
