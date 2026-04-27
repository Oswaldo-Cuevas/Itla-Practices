using CrudApiConInterfaces.Interfaces;
using CrudApiConInterfaces.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios básicos
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Registrar el repositorio con inyección de dependencias
builder.Services.AddSingleton<IProductoRepository, ProductoRepository>();

var app = builder.Build();

// Configuración de Swagger (para probar el API)
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();

// Mapear los controladores
app.MapControllers();
