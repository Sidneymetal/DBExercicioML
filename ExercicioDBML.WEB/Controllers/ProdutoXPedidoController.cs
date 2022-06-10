using Microsoft.AspNetCore.Mvc;
using ExercicioDBML.Lib.Models;
using ExercicioDBML.Lib.Data.Repositorio;
using ExercicioDBML.WEB.DTOs;

namespace ExercicioDBML.WEB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoXPedidoController : ControllerBase
    {
        private readonly ILogger<ProdutoXPedidoController> _logger;
        private readonly ProdutoXPedidoRepositorio _repositorio;
        public ProdutoXPedidoController(ILogger<ProdutoXPedidoController> logger, ProdutoXPedidoRepositorio repositorio)
        {
            _logger = logger;
            _repositorio = repositorio;
        }
        [HttpGet("ListarTodos")]
        public IActionResult ListarTodos()
        {
            return Ok(_repositorio.ListarTodos());
        }
        [HttpGet("{id}")]
        public IActionResult ListarProdutosXPedidosId(int id)
        {
            return Ok(_repositorio.ListarTodosPorId(id));
        }
        [HttpPost()]
        public IActionResult AdicionarProdutosXPedidos(ProdutoXPedidoDTO produtoXPedidoDTO)
        {
            var produto = new ProdutoXPedido(produtoXPedidoDTO.IdPxp, produtoXPedidoDTO.IdProduto, produtoXPedidoDTO.IdPedido, produtoXPedidoDTO.Produto, produtoXPedidoDTO.Pedido);
            _repositorio.Adicionar(produto);
            return Ok("PedidosXprodutos adicionado.");
        }
        [HttpPut()]
        public IActionResult AlterarDadosProduto(int id, int idProduto)
        {
            _repositorio.AlterarProduto(id, idProduto);
            return Ok("Produto alterado.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeletarProdutoXPedidoPorId(int id)
        {
            _repositorio.Deletar(id);
            return Ok("ProdutosXPedidos removido.");
        }
    }
}