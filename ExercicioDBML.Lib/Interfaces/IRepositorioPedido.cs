using ExercicioDBML.Lib.Data.Repositorio;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Interfaces
{
    public interface IRepositorioPedido : IRepositorioBase<Pedido>
    {
        public void AlterarStatusPedido(int id, string status);
    }
}