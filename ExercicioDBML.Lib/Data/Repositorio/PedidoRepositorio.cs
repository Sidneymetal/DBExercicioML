using ExercicioDBML.Lib.Interfaces;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Data.Repositorio
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IRepositorioPedido
    {
        public PedidoRepositorio(ExercicioMLContext context) : base (context, context.Pedidos)
        {
            
        }
        public void AlterarStatusPedido(int id, string status)
        {
            var pedido = _dbset.Find(id);
            pedido.status = status;
            _context.SaveChanges();
        }
    }
}