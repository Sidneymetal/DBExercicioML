using ExercicioDBML.Lib.Data.Repositorio;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Interfaces
{
    public interface IRepositorioUsuario : IRepositorioBase<Usuario>
    {
        public void AlterarSenhaUsuario(int id, string senha);        
    }
}