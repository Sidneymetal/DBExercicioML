using ExercicioDBML.Lib.Interfaces;
using ExercicioDBML.Lib.Models;
namespace ExercicioDBML.Lib.Data.Repositorio
{
    public class TransportadoraRepositorio : BaseRepositorio<Transportadora>, ITransportadoraRepositorio
    {
        public TransportadoraRepositorio(ExercicioMLContext context) : base(context, context.Transportadoras)
        {

        }
        public void AlterarEmailTransportadora(int id, string email)
        {
            var item = _dbset.Find(id);
            item.Email = email;
            _context.SaveChanges();
        }
    }
}