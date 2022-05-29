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
            modelBuilder.Entity<Pedidos>().HasKey(key => key.Id);
            modelBuilder.Entity<Pedidos>()
                .HasOne(x => x.ProdutosXPedidos)
                .WithOne(x => x.Pedidos);

            modelBuilder.Entity<Produtos>().ToTable("Produtos");            
            
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