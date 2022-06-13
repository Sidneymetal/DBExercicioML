using ExercicioDBML.Lib.Data.Interfaces;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Interfaces
{
    public interface ITransportadoraRepositorio: IBaseRepositorio<Transportadora>
    {
        void AlterarEmailTransportadora(int id, string email);
    }
}