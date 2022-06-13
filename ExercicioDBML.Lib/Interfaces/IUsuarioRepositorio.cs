using ExercicioDBML.Lib.Data.Interfaces;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Interfaces
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        void AlterarSenhaUsuario(int id, string senha);        
    }
}