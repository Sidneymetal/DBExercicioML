using Microsoft.EntityFrameworkCore;

namespace ExercicioDBML.Lib.Data
{
    public class ExercicioMLContext : DbContext
    {
        
    }
    public DbSet<Pedidos> Pedidos { get; set; }
    public DbSet<Produtos> Produtos { get; set; }
    public DbSet<Transportadores> Transportadores { get; set; }
    public DbSet<Usuarios> Usuarios { get; set; }
    public DbSet<Vendedores> Vendedores { get; set; }
    public DbSet<ProdutosXPedidos> ProdutosXPedidos { get; set; }
}