# personapi-dotnet

Proyecto académico: Implementación de un **monolito** con **patrón MVC y DAO** en ASP.NET Core para la gestión de datos de personas.

## 📚 Descripción

Este proyecto fue desarrollado como parte del laboratorio 1 del curso de desarrollo de aplicaciones empresariales. Consiste en una aplicación ASP.NET Core MVC que permite realizar operaciones CRUD sobre una base de datos relacional SQL Server.

## 🛠️ Tecnologías utilizadas

- .NET 7 (ASP.NET Core MVC)
- Microsoft SQL Server 2022
- Entity Framework Core
- Swagger 3 para documentación de la API
- Visual Studio Community 2022

---

## ⚙️ Configuración del entorno

### Prerrequisitos

- SQL Server 2019 Express (modo básico)
- SQL Server Management Studio 18
- Visual Studio Community 2022 con los siguientes componentes:
  - Desarrollo de ASP.NET y web
  - Almacenamiento y procesamiento de datos
  - Plantillas de proyecto y elementos de .NET Framework
  - Características avanzadas de ASP.NET
- .NET 6 o 7 SDK instalado

### Pasos de instalación

1. **Clonar el repositorio**

```bash
git clone https://github.com/tu_usuario/personapi-dotnet.git
cd personapi-dotnet
Crear base de datos

Abrir SQL Server Management Studio

Conectarse al servidor local localhost\SQLEXPRESS

Ejecutar el script DDL-DML.sql para crear la base de datos persona_db y poblarla con datos iniciales

Cadena de conexión

En appsettings.json:

json
Copiar
Editar
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=persona_db;Trusted_Connection=True;TrustServerCertificate=true"
}
Generar entidades con Scaffold

Abrir la consola del administrador de paquetes en Visual Studio:

powershell
Copiar
Editar
Scaffold-DbContext "Server=localhost\SQLEXPRESS;Database=persona_db;Trusted_Connection=True;TrustServerCertificate=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models/Entities
Esto generará automáticamente las entidades del modelo y el contexto de base de datos.

🚀 Ejecución
En Visual Studio:

Seleccionar el proyecto personapi-dotnet

Presionar F5 o hacer clic en Iniciar

Acceder a la documentación Swagger en:
http://localhost:<puerto>/swagger

📁 Estructura del repositorio
bash
Copiar
Editar
personapi-dotnet/
│
├── Models/
│   └── Entities/         # Entidades generadas por EF Core
│
├── Repositories/         # Interfaces y DAO
├── Controllers/          # Lógica de endpoints
├── Views/                # Vistas (si aplica)
├── appsettings.json      # Configuración
├── DDL-DML.sql           # Script de base de datos
├── README.md             # Este archivo
├── DOCUMENTACION/
│   ├── Portada.pdf
│   ├── Marco_Conceptual.pdf
│   ├── Diseño.pdf
│   ├── Procedimiento.pdf
│   ├── Conclusiones_Lecciones.pdf
│   └── Referencias.pdf
🧪 Funcionalidad
CRUD de personas (modelo Persona)

Vistas asociadas a las operaciones

API REST documentada con Swagger

📄 Licencia
Este proyecto está licenciado bajo la Licencia MIT.

👨‍💻 Autor
Nombre: Tu Nombre Aquí

Universidad / Curso: Nombre del curso o asignatura

GitHub: @tu_usuario
