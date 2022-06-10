using ExercicioDBML.Lib.Data.Repositorio;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Interfaces
{
    public interface IRepositorioProdutoXPedido : IRepositorioBase<ProdutoXPedido>
    {
        public void AlterarProduto(int id, int idProduto);      
    }
}