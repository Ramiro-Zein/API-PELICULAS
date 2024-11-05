# 🎬 Movie API 🌟

¡Bienvenido a la API de base de datos de películas! Esta API está construida en .NET 8 y diseñada para alimentar un sitio de películas con toda la información que necesitas sobre tus filmes favoritos. 🚀

## 🚀 Tecnologías

- .NET 8
- Entity Framework Core
- SQL Server (o base de datos a elección)

## 🌐 Endpoints

### 📋 Películas

- **GET /api/movies** - Obtiene todas las películas
- **GET /api/movies/{id}** - Obtiene una película por ID
- **POST /api/movies** - Crea una nueva película
- **PUT /api/movies/{id}** - Actualiza una película
- **DELETE /api/movies/{id}** - Elimina una película

### 🌟 Géneros

- **GET /api/genres** - Obtiene todos los géneros
- **POST /api/genres** - Crea un nuevo género

## 🛠 Configuración

1. Clona este repositorio:
   ```bash
   git clone https://github.com/tu-usuario/movie-api.git

2.
  ```bash
  dotnet ef database update

3.
  ```bash
  dotnet run
