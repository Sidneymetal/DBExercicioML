using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Data;
namespace ExercicioDBML.Lib.Models
{
    public class ProdutoXPedido
    {
        public int IdProdutoXPedido { get; set; }
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }
        public Produto Produto { get; set; }
        public Pedido Pedido { get; set; }

        public ProdutoXPedido()
        {

        }
        public ProdutoXPedido(int idProdutoXPedido, int idProduto, int idPedido, Produto produto, Pedido pedido)
        {
            IdProdutoXPedido = idProdutoXPedido;
            IdProduto = idProduto;
            IdPedido = idPedido;
            Produto = produto;
            Pedido = pedido;
        }
    }
}