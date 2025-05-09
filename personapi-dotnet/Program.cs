using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;
using personapi_dotnet.Repositories.Implementations;
using personapi_dotnet.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// 1) Registrar DbContext con SQL Server
builder.Services.AddDbContext<PersonaDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
        )
);

// 2) Registrar repositorios 
builder.Services
    .AddScoped<IPersonaRepository, PersonaRepository>()
    .AddScoped<IProfesionRepository, ProfesionRepository>()
    .AddScoped<IEstudiosRepository, EstudiosRepository>()
    .AddScoped<ITelefonoRepository, TelefonoRepository>();

// 3) Añadir servicios MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
