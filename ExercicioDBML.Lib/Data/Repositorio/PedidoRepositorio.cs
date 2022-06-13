using ExercicioDBML.Lib.Interfaces;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Data.Repositorio
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(ExercicioMLContext context) : base (context, context.Pedidos)
        {
            
        }
        public void AlterarStatusPedido(int id, string status)
        {
            var pedido = _dbset.Find(id);
            pedido.Status = status;
            _context.SaveChanges();
        }
    }
}