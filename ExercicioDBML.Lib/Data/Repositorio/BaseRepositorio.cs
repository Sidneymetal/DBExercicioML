using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Data.Repositorio
{
    public class BaseRepositorio <T> where T :class
    {
        protected readonly ExercicioMLContext _context;
        protected readonly DbSet<T> _dbset;
        public BaseRepositorio(ExercicioMLContext dbContext, DbSet<T> dbset)
        {
            _context = dbContext;
            _dbset = dbset;
        }
        public List<T> ListarTodos()
        {
            return _dbset.AsNoTracking().ToList();           
        }             
        public T ListarTodosPorId(int id)
        {
            return _dbset.Find(id);
        }
        public void Adicionar(T item)
        {
            _dbset.Add(item);
            _context.SaveChanges();
        }
        public void Deletar(int id)
        {
            var item = _dbset.Find(id);
            _dbset.Remove(item);
            _context.SaveChanges();
        }
    }
}