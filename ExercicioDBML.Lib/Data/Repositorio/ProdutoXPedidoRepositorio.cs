using ExercicioDBML.Lib.Interfaces;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Data.Repositorio
{
    public class ProdutoXPedidoRepositorio : BaseRepositorio<ProdutoXPedido>, IProdutoXPedidoRepositorio
    {
        public ProdutoXPedidoRepositorio(ExercicioMLContext context) : base(context, context.ProdutosXPedidos)
        {

        }
        public void AlterarProduto(int id, int idProduto)
        {
            var item = _dbset.Find(id);
            item.IdProduto = idProduto;
            _context.SaveChanges();
        }
    }
}