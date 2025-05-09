# personapi-dotnet

Proyecto académico: Implementación de un **monolito** con **patrón MVC y DAO** en ASP.NET Core para la gestión de datos de personas.

## 📚 Descripción

Este proyecto fue desarrollado como parte del laboratorio 1 del curso de desarrollo de aplicaciones empresariales. Consiste en una aplicación ASP.NET Core MVC que permite realizar operaciones CRUD sobre una base de datos relacional SQL Server.

## 🛠️ Tecnologías utilizadas

- .NET 7 (ASP.NET Core MVC)
- Microsoft SQL Server 2022
- Swagger 3 para documentación de la API
- Visual Studio Code o Visual Studio Community 2022
- Docker y Docker Compose

---

## ⚙️ Configuración del entorno

### 🔧 Prerrequisitos

- Docker y Docker Compose instalados
- (Opcional) Visual Studio Code o Visual Studio Community 2022

---

### 📥 Pasos de instalación y uso con Docker

#### 1. Clonar el repositorio

```bash
git clone https://github.com/tu_usuario/personapi-dotnet.git
cd personapi-dotnet
```

#### 2. Levantar los servicios con Docker Compose

```bash
docker-compose up --build
```

Esto levantará dos contenedores:
- **sql_server**: Instancia de SQL Server 2022 con la base de datos y tablas inicializadas automáticamente.
- **personapi**: Aplicación ASP.NET Core MVC conectada a la base de datos.

> **Nota:** El script de inicialización puede requerir permisos, ejecutar el siguiente comando si es necesario:
```bash
chmod +x database/*
```

#### 3. Acceder a la aplicación

- **Swagger UI:**  
  [http://localhost:8081/swagger](http://localhost:8081/swagger)

- **Vistas web:**  
  [http://localhost:8081/](http://localhost:8081/)


#### 4. Parar y limpiar los contenedores

```bash
docker-compose down
```

---

## 📁 Estructura del repositorio

```bash
personapi-dotnet/
│
├── Models/
│   └── Entities/           # Entidades generadas por EF Core
│
├── Repositories/           # Interfaces y DAO
├── Controllers/            # Lógica de endpoints
├── Views/                  # Vistas MVC
├── appsettings.json        # Configuración
├── database/
│   ├── schema.sql          # Script de base de datos
│   └── entrypoint.sh       # Script de inicialización
├── docker-compose.yml      # Orquestador de servicios
├── README.md               # Este archivo

```