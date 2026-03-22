using Microsoft.EntityFrameworkCore;
using SoundJournal.Infrastructure.Data;
using SoundJournal.Domain.Repository;
using SoundJournal.Infrastructure.Repositories;

// 👇 Importa tu capa Application
using SoundJournal.Application.Contract;
using SoundJournal.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Repositorios (Domain + Infrastructure)
builder.Services.AddScoped<IPodcastEpisodeRepository, PodcastEpisodeRepository>();

// Servicios (Application Layer)
builder.Services.AddScoped<IDepartmentService, DepartmentService>();

// DbContext
builder.Services.AddDbContext<SoundJournalContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Servicios API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger solo en desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middlewares
app.UseHttpsRedirection();
app.UseAuthorization();

// Endpoints
app.MapControllers();

app.Run();