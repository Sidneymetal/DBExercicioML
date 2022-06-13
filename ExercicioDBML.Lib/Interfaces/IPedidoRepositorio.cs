using ExercicioDBML.Lib.Data.Interfaces;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Interfaces
{
    public interface IPedidoRepositorio : IBaseRepositorio<Pedido>
    {
        void AlterarStatusPedido(int id, string status);
    }
}