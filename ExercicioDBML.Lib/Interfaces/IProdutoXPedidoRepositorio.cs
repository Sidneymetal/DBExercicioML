using ExercicioDBML.Lib.Data.Interfaces;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Interfaces
{
    public interface IProdutoXPedidoRepositorio : IBaseRepositorio<ProdutoXPedido>
    {
        void AlterarProduto(int id, int idProduto);
    }
}