using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Data;
using ExercicioDBML.Lib.Data.Repositorio;
using Microsoft.AspNetCore.Mvc;
using ExercicioDBML.Lib.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ExercicioMLContext>(conn => conn.UseNpgsql(builder.Configuration.GetConnectionString("DiagramaMercadoLivre")).UseSnakeCaseNamingConvention());

builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddScoped<ProdutoRepositorio>();
builder.Services.AddScoped<PedidoRepositorio>();
builder.Services.AddScoped<ProdutoXPedidoRepositorio>();
builder.Services.AddScoped<TransportadoraRepositorio>();
builder.Services.AddScoped<UsuarioRepositorio>();
builder.Services.AddScoped<VendedorRepositorio>();
builder.Services.AddScoped<IRepositorioProduto, ProdutoRepositorio>();
builder.Services.AddScoped<IRepositorioPedido, PedidoRepositorio>();
builder.Services.AddScoped<IRepositorioProdutoXPedido, ProdutoXPedidoRepositorio>();
builder.Services.AddScoped<IRepositorioTrasportadora, TransportadoraRepositorio>();
builder.Services.AddScoped<IRepositorioUsuario, UsuarioRepositorio>();
builder.Services.AddScoped<IRepositorioVendedor, VendedorRepositorio>();

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
