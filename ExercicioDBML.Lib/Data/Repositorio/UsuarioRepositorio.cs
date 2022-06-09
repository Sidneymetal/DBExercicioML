using ExercicioDBML.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace ExercicioDBML.Lib.Data.Repositorio
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario> 
    {    
        public UsuarioRepositorio(ExercicioMLContext context) : base(context, context.Usuarios)
        {
                        
        }
        public void AlterarSenhaUsuario(int id, string senha)
        {
            var usuario = _dbset.Find(id);
            usuario.Senha = senha;
            _context.SaveChanges();
        }
    }
}