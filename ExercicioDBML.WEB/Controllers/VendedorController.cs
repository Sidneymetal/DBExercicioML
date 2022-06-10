using Microsoft.AspNetCore.Mvc;
using ExercicioDBML.Lib.Models;
using ExercicioDBML.WEB.DTOs;
using ExercicioDBML.Lib.Data.Repositorio;

namespace ExercicioDBML.WEB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendedorController : ControllerBase
    {
        private readonly ILogger<VendedorController> _logger;
        private readonly VendedorRepositorio _repositorio;

        public VendedorController(ILogger<VendedorController> logger, VendedorRepositorio repositorio)
        {
            _logger = logger;
            _repositorio = repositorio;
        }
        [HttpGet("ListarTodos")]
        public IActionResult ListarVendedores()
        {
          return Ok(_repositorio.ListarTodos());
        }
        [HttpGet("ListarTodosPorId")]
        public IActionResult ListarVendedoresId(int id)
        {
            return Ok(_repositorio.ListarTodosPorId(id));
        }
        [HttpPost()]
        public IActionResult AdicionarVendedor(VendedorDTO vendedorDTO)
        {
            var vendedor = new Vendedor(vendedorDTO.IdVendedor, vendedorDTO.Nome, vendedorDTO.Email, vendedorDTO.Cnpj, vendedorDTO.DataCadastro);
            _repositorio.Adicionar(vendedor);
            return Ok("Vendedor adicionado.");
        }
        [HttpPut()]
        public IActionResult AlterarDadosVendedor(int id, string email)
        {
            _repositorio.AlterarEmail(id, email);
            return Ok("Vendedor alterado.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeletarVendedorPorId(int id)
        {
           _repositorio.Deletar(id);
            return Ok("Vendedor Removida.");
        }
    }
}