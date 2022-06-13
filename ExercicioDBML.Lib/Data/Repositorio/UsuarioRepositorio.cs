using ExercicioDBML.Lib.Interfaces;
using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.Lib.Data.Repositorio
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
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