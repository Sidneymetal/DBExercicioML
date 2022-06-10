using Microsoft.AspNetCore.Mvc;
using ExercicioDBML.Lib.Models;
using ExercicioDBML.WEB.DTOs;
using ExercicioDBML.Lib.Data.Repositorio;

namespace ExercicioDBML.WEB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        protected readonly ILogger<PedidoController> _logger;
        protected readonly PedidoRepositorio _repositorio;

        public PedidoController(ILogger<PedidoController> logger, PedidoRepositorio repositorio)
        {
            _logger = logger;
            _repositorio = repositorio;
        }
        [HttpGet("ListarTodos")]
        public IActionResult ListarPedidos()
        {
            return Ok(_repositorio.ListarTodos());
        }
        [HttpGet("{id}")]
        public IActionResult ListarPedidosPorId(int id)
        {
            return Ok(_repositorio.ListarTodosPorId(id));
        }
        [HttpPost()]
        public IActionResult AdicionarPedidos(PedidoDTO pedidoDTO)
        {
            var pedido = new Pedido(pedidoDTO.Id, pedidoDTO.IdTransportadora, pedidoDTO.IdUsuario, pedidoDTO.DataPedido, pedidoDTO.StatusPedido, pedidoDTO.Transportadora, pedidoDTO.Cliente);
            _repositorio.Adicionar(pedido);
            return Ok("Pedido adicionado.");
        }
        [HttpPut()]
        public IActionResult AlterarStatusPedido(int id, string status)
        {
            _repositorio.AlterarStatusPedido(id, status);
            return Ok("Status do pedido alterado.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeletarPedidoPorId(int id)
        {
            _repositorio.Deletar(id);
            return Ok("Pedido Removido.");
        }
    }
}