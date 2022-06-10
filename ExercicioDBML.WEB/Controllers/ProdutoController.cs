using Microsoft.AspNetCore.Mvc;
using ExercicioDBML.Lib.Models;
using ExercicioDBML.WEB.DTOs;
using ExercicioDBML.Lib.Data.Repositorio;

namespace ExercicioDBML.WEB.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProdutoController : ControllerBase
    {
        private readonly ILogger<ProdutoController> _logger;
        private readonly ProdutoRepositorio _repositorio;

        public ProdutoController(ILogger<ProdutoController> logger, ProdutoRepositorio repositorio) 
        {
            _logger = logger;
            _repositorio = repositorio;
        }
        [HttpGet("ListarTodos")]
        public IActionResult ListarProdutos()
        {
            return Ok(_repositorio.ListarTodos());
        }
        [HttpGet("{id}")]
        public IActionResult ListarProdutosPorId(int id)
        {
            return Ok(_repositorio.ListarTodosPorId(id));
        }
        [HttpGet("IncluindoVendedor")]
        public IActionResult ListarProdutosIncluindoVendedor()
        {
            return Ok(_repositorio.ListarProdutosIncluindoVendedor());
        }
        [HttpPost()]
        public IActionResult AdicionarProdutos(ProdutoDTO produtoDTO)
        {
            var produto = new Produto(produtoDTO.IdProduto, produtoDTO.IdVendedor, produtoDTO.Nome, produtoDTO.Descricao, produtoDTO.Valor, produtoDTO.DataCadastro, produtoDTO.Vendedor);
            _repositorio.Adicionar(produto);
            return Ok(produto); 
        }
        [HttpPut()]
        public IActionResult AlterarValorDoProduto(int id, double valor)
        {
            _repositorio.AlterarValorProduto(id, valor);
            return Ok("Valor do produto alterado.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeletarProdutoPorId(int id)
        {
            _repositorio.Deletar(id);
            return Ok("Produto Removido.");
        }
    }
}
