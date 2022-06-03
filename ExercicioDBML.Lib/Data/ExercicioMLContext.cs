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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pedidos>().ToTable("Pedidos");
            modelBuilder.Entity<Pedidos>().HasKey(key => key.Id);
            modelBuilder.Entity<Pedidos>().HasOne(x => x.Transportadoras)
                                            .WithMany(x => x.PegarPedidos)
                                            .HasForeignKey(x => x.IdTransportadora);
            modelBuilder.Entity<Pedidos>().HasOne(x => x.Usuarios)
                                            .WithMany(x => x.PegarPedidos)
                                            .HasForeignKey(x => x.IdUsuario);                       

            modelBuilder.Entity<Produtos>().ToTable("Produtos");
            modelBuilder.Entity<Produtos>().HasKey(key => key.Id);
            modelBuilder.Entity<Produtos>().HasOne(x => x.Vendedor)
                                            .WithMany(x => x.ListaProdutos)
                                            .HasForeignKey(x => x.IdVendedor);

            modelBuilder.Entity<ProdutosXPedidos>().ToTable("ProdutosXPedidos");
            modelBuilder.Entity<ProdutosXPedidos>().HasKey(key => key.Id);
            modelBuilder.Entity<ProdutosXPedidos>().HasOne(x => x.Produtos)
                                                    .WithMany(x => x.ProdutosXPedidos)
                                                    .HasForeignKey(x => x.IdProduto);
            modelBuilder.Entity<ProdutosXPedidos>().HasOne(x => x.Pedidos)
                                                    .WithMany(x => x.ProdutosXPedidos)
                                                    .HasForeignKey(x => x.IdPedido);

            modelBuilder.Entity<Usuarios>().ToTable("Usuarios");
            modelBuilder.Entity<Usuarios>().HasKey(key => key.Id);
            modelBuilder.Entity<Usuarios>().HasMany(x => x.Pedidos)
                                            .WithMany(x => x.Produtos)
                                            .HasForeignKey(x => x.IdUsuario);

            modelBuilder.Entity<Transportadoras>().ToTable("Transportadoras");
            modelBuilder.Entity<Transportadoras>().HasKey(key => key.Id);
            modelBuilder.Entity<Transportadoras>().HasMany(x => x.Pedidos)
                                            .WithMany(x => x.Produtos)
                                            .HasForeignKey(x => x.IdTransportadora);
        }

        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Transportadoras> Transportadoras { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
        public DbSet<ProdutosXPedidos> ProdutosXPedidos { get; set; }
    }
}