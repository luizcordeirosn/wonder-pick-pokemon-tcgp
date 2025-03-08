using Microsoft.EntityFrameworkCore;
using wonder_pick_pokemon_tcgp.src.data;
using wonder_pick_pokemon_tcgp.src.repositories;
using wonder_pick_pokemon_tcgp.src.services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configuração do PostgreSQL
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<IWonderPickRepository, WonderPickRepository>();
builder.Services.AddScoped<IWonderPickService, WonderPickService>();

var app = builder.Build();

app.UseMiddleware<GlobalErrorHandling>();

app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();
app.MapControllers();
app.Run();
