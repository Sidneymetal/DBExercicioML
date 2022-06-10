using ExercicioDBML.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace ExercicioDBML.Lib.Data.Repositorio
{
    public class BaseRepositorio <T> : IRepositorioBase <T> where T : ModelBase
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
            return _dbset.AsNoTracking().First(x => x.Id == id);
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