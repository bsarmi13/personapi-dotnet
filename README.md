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

### 🔧 Prerrequisitos

- SQL Server 2019 Express (modo básico)
- SQL Server Management Studio 18
- Visual Studio Community 2022 con los siguientes componentes:
  - Desarrollo de ASP.NET y web
  - Almacenamiento y procesamiento de datos
  - Plantillas de proyecto y elementos de .NET Framework
  - Características avanzadas de ASP.NET
- .NET 6 o 7 SDK instalado

---

### 📥 Pasos de instalación

#### 1. Clonar el repositorio

```bash
git clone https://github.com/tu_usuario/personapi-dotnet.git
cd personapi-dotnet
```
#### 2. Crear la base de datos
- Abrir SQL Server Management Studio
- Conectarse al servidor local localhost\SQLEXPRESS
- Ejecutar el script DDL-DML.sql para crear la base de datos persona_db y poblarla con datos iniciales

#### 3. Configurar la cadena de conexión
En appsettings.json:
```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=persona_db;Trusted_Connection=True;TrustServerCertificate=true"
}
```
#### 4. Generar entidades con Scaffold
En la Consola del Administrador de Paquetes:
```bash
Scaffold-DbContext "Server=localhost\\SQLEXPRESS;Database=persona_db;Trusted_Connection=True;TrustServerCertificate=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models/Entities
```
Esto generará automáticamente las clases de entidad y el DbContext a partir de la base de datos.

#### Ejecución del proyecto
- Abrir el proyecto en Visual Studio
- Asegurarse de que el proyecto personapi-dotnet está seleccionado como proyecto de inicio
- Presionar F5 o hacer clic en Iniciar
- Acceder a Swagger en:
  http://localhost:{puerto}/swagger

📁 Estructura del repositorio
```bash
personapi-dotnet/
│
├── Models/
│   └── Entities/           # Entidades generadas por EF Core
│
├── Repositories/           # Interfaces y DAO
├── Controllers/            # Lógica de endpoints
├── Views/                  # Vistas (si aplica)
├── appsettings.json        # Configuración
├── DDL-DML.sql             # Script de base de datos
├── README.md               # Este archivo
├── DOCUMENTACION/
│   ├── Portada.pdf
│   ├── Marco_Conceptual.pdf
│   ├── Diseño.pdf
│   ├── Procedimiento.pdf
│   ├── Conclusiones_Lecciones.pdf
│   └── Referencias.pdf
```
### Funcionalidad
- CRUD completo del modelo Persona
- Vistas web (si aplica)
- API REST documentada con Swagger

### Autores
- Nombre: 
- Universidad :Pontificia Universidad Javeriana
- Curso: Arquitectura de Software

