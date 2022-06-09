using Microsoft.AspNetCore.Mvc;
using ExercicioDBML.Lib.Models;
using ExercicioDBML.WEB.DTOs;
using ExercicioDBML.Lib.Data.Repositorio;
namespace ExercicioDBML.WEB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly UsuarioRepositorio _repositorio;

        public UsuarioController(ILogger<UsuarioController> logger, UsuarioRepositorio repositorio)
        {
            _logger = logger;
            _repositorio = repositorio;
        }        
        [HttpGet("ListarTodos")]
        public IActionResult ListarTodos()
        {
           return Ok(_repositorio.ListarTodos());
        }
        [HttpGet("ListarTodosPorId")]
        public IActionResult ListarTodosPorId(int id)
        {
            return Ok(_repositorio.ListarTodosPorId(id));
        }        
        [HttpPost()]
        public IActionResult AdicionarUsuario(UsuarioDTO usuarioDto)
        {
            var usuario = new Usuario(usuarioDto.IdUsuario, usuarioDto.Nome, usuarioDto.Email, usuarioDto.Cpf, usuarioDto.DataNascimento, usuarioDto.Senha);
            _repositorio.Adicionar(usuario);           
            return Ok("Usuário adicionado.");
        }
        [HttpPut()]
        public IActionResult AlterarSenhaDoUsuario(int id, string senha)
        {
            _repositorio.AlterarSenhaUsuario(id, senha);
            return Ok("Senha alterada.");
        }        
        [HttpDelete("{id}")]
        public IActionResult RemoverUsuarioPorId(int id)
        {
            _repositorio.Deletar(id);
            return Ok("Usuário removido.");
        }
    }
}