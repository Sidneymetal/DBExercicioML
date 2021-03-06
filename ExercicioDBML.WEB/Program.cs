using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Data;
using ExercicioDBML.Lib.Data.Repositorio;
using Microsoft.AspNetCore.Mvc;
using ExercicioDBML.Lib.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ExercicioMLContext>(conn => conn.UseNpgsql(builder.Configuration.GetConnectionString("DiagramaMercadoLivre")).UseSnakeCaseNamingConvention());

builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();
builder.Services.AddScoped<IPedidoRepositorio, PedidoRepositorio>();
builder.Services.AddScoped<IProdutoXPedidoRepositorio, ProdutoXPedidoRepositorio>();
builder.Services.AddScoped<ITransportadoraRepositorio, TransportadoraRepositorio>();
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
builder.Services.AddScoped<IVendedorRepositorio, VendedorRepositorio>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
