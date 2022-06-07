using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Data;
using ExercicioDBML.Lib.Models;
using ExercicioDBML.WEB.DTOs;
namespace ExercicioDBML.WEB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly ExercicioMLContext _context;

        public UsuarioController(ILogger<UsuarioController> logger, ExercicioMLContext context)
        {
            _logger = logger;
            _context = context;
        }
        //Create
        [HttpGet()]
        public IActionResult GetTodos()
        {
            var pedidos = _context.Usuarios.ToList();
            return Ok(pedidos);
        }
        //Read
        [HttpGet("{id}")]
        public IActionResult GetPorId(int id)
        {            
            return Ok(_context.Usuarios.Find(id));
        }
        //Update
        [HttpPost("{id}")]
        public IActionResult SalvarPorId(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut("AlterarSenha/{id}/{senha}")]
        public IActionResult AlterarSenha(int id, string senha)
        {
            var usuario = _context.Usuarios.Find(id);
            usuario.Senha = senha;
            _context.SaveChanges();
            return Ok(usuario);
        }
        [HttpPost("Adicionar")]
        public IActionResult Adicionar(PedidoDTO pedidoDto)
        {
            var pedido = new Pedido(pedidoDto.IdPedido, pedidoDto.IdTransportadora, pedidoDto.IdUsuario, pedidoDto.DataPedido, pedidoDto.StatusPedido, pedidoDto.Transportadora, pedidoDto.Cliente);
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
            return Ok(pedido);
        }
        //Delete
        [HttpDelete("Deletar/{id}")]
        public IActionResult DeletarUsuarioPorId(int id)
        {
            var usuario = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            return Ok("Usuario Removido.");
        }
    }
}
