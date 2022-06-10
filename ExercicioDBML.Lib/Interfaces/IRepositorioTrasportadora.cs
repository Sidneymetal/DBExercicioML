using ExercicioDBML.Lib.Data.Repositorio;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Interfaces
{
    public interface IRepositorioTrasportadora : IRepositorioBase<Transportadora>
    {
        public void AlterarEmailTransportadora(int id, string email);
    }
}