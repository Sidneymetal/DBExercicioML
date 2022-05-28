using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Models;
namespace ExercicioDBML.Lib.Data
{
    public class ExercicioMLContext : DbContext
    {
        public ExercicioMLContext(DbContext context) : base (context)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pedidos>().ToTable("Pedidos");
            modelBuilder.Entity<Produtos>().ToTable("Produtos");
            modelBuilder.Entity<Transportadores>().ToTable("Transportadores");
            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");
            modelBuilder.Entity<Vendedores>().ToTable("Vendedores");
            modelBuilder.Entity<ProdutosXPedidos>().ToTable("ProdutosXPedidos");
        }

        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Transportadores> Transportadores { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
        public DbSet<ProdutosXPedidos> ProdutosXPedidos { get; set; }
    }    
}