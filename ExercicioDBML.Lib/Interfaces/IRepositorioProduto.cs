using ExercicioDBML.Lib.Data.Repositorio;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Interfaces
{
    public interface IRepositorioProduto : IRepositorioBase<Produto>
    {
        public List<Produto> ListarProdutosIncluindoVendedor();       
        public void AlterarValorProduto(int id, double valor);       
    }
}