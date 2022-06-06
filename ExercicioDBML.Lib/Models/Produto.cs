using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Data;
namespace ExercicioDBML.Lib.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public int IdVendedor { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public Vendedor? Vendedor { get; set; }
        public List<ProdutoXPedido> ListaProdutosXPedidos { get; set; }
        public Produto()
        {

        }
        public Produto(int idProduto, int idVendedor, string nome, string descricao, Double valor, DateTime dataCadastro, Vendedor vendedor)
        {
            IdProduto = idProduto;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            DataCadastro = dataCadastro;
            Vendedor = vendedor;
        }
    }
}