using ExercicioDBML.Lib.Data.Interfaces;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Interfaces
{
    public interface IVendedorRepositorio : IBaseRepositorio<Vendedor>
    {
        void AlterarEmail(int id, string email);
    }
}