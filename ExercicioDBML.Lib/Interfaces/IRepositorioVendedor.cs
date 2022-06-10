using ExercicioDBML.Lib.Data.Repositorio;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Interfaces
{
    public interface IRepositorioVendedor : IRepositorioBase<Vendedor>
    {
        public void AlterarEmail(int id, string email);       
    }
}