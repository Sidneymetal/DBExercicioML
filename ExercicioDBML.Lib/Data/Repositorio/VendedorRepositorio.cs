using ExercicioDBML.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace ExercicioDBML.Lib.Data.Repositorio
{
    public class VendedorRepositorio : BaseRepositorio<Vendedor>
    {
        public VendedorRepositorio(ExercicioMLContext context) : base( context, context.Vendedores)
        {

        }
        public void AlterarEmail(int id, string email)
        {
            var item = _dbset.Find(id);
            item.Email = email;
            _context.SaveChanges();
        }      
    }
}