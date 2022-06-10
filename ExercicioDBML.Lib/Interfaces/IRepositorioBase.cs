using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Data.Repositorio
{
    public interface IRepositorioBase <T> where T : ModelBase
    {
        public List<T> ListarTodos();
        public T ListarTodosPorId(int id);       
        public void Adicionar(T item);
        public void Deletar(int id);        
    }
}