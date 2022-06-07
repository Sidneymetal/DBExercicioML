using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Models;
namespace ExercicioDBML.Lib.Data
{
    public class ExercicioMLContext : DbContext
    {
        public ExercicioMLContext(DbContextOptions context) : base(context)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>().ToTable("mlt_pedidos");
            modelBuilder.Entity<Pedido>().HasKey(x => x.Id);
            modelBuilder.Entity<Pedido>().HasOne(x => x.Transportadora).WithMany(x => x.ListaPedidos).HasForeignKey(x => x.IdTransportadora);
            modelBuilder.Entity<Pedido>().HasOne(x => x.Cliente).WithMany(x => x.ListaPedidos).HasForeignKey(x => x.IdUsuario);

            modelBuilder.Entity<Produto>().ToTable("mlt_produtos");
            modelBuilder.Entity<Produto>().HasKey(x => x.IdProduto);
            modelBuilder.Entity<Produto>().HasOne(x => x.Vendedor).WithMany(x => x.ListaProdutos).HasForeignKey(x => x.IdVendedor);

            modelBuilder.Entity<Transportadora>().ToTable("mlt_transportadoras");
            modelBuilder.Entity<Transportadora>().HasKey(x => x.IdTransportadora);
            modelBuilder.Entity<Transportadora>().HasMany(x => x.ListaPedidos).WithOne(x => x.Transportadora);

            modelBuilder.Entity<Vendedor>().ToTable("mlt_vendedores");
            modelBuilder.Entity<Vendedor>().HasKey(x => x.IdVendedor);
            modelBuilder.Entity<Vendedor>().HasMany(x => x.ListaProdutos).WithOne(x => x.Vendedor).HasForeignKey(x => x.IdVendedor);

            modelBuilder.Entity<Usuario>().ToTable("mlt_usuarios");
            modelBuilder.Entity<Usuario>().HasKey(x => x.Id);
            modelBuilder.Entity<Usuario>().HasMany(x => x.ListaPedidos).WithOne(x => x.Cliente).HasForeignKey(x => x.Id);

            modelBuilder.Entity<ProdutoXPedido>().ToTable("mlt_produtosxpedidos");
            modelBuilder.Entity<ProdutoXPedido>().HasKey(x => x.IdProdutoXPedido);
            modelBuilder.Entity<ProdutoXPedido>().HasOne(x => x.Produto).WithMany(x => x.ListaProdutosXPedidos).HasForeignKey(x => x.IdProduto);
            modelBuilder.Entity<ProdutoXPedido>().HasOne(x => x.Pedido).WithMany(x => x.ListaProdutosXPedidos).HasForeignKey(x => x.IdPedido);
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoXPedido> ProdutosXPedidos { get; set; }
        public DbSet<Transportadora> Transportadoras { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
    }
}