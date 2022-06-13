using ExercicioDBML.Lib.Data.Interfaces;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Interfaces
{
    public interface IProdutoRepositorio : IBaseRepositorio<Produto>
    {
        List<Produto> ListarProdutosIncluindoVendedor();       
        void AlterarValorProduto(int id, double valor);             
    }
}