using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Data.Interfaces
{
    public interface IBaseRepositorio <T> where T : ModelBase
    {
        List<T> ListarTodos();
        T ListarTodosPorId(int id);
        void Adicionar(T item);
        void Deletar(int id);
    }
}