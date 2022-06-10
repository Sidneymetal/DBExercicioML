using Microsoft.AspNetCore.Mvc;
using ExercicioDBML.Lib.Models;
using ExercicioDBML.Lib.Data.Repositorio;
using ExercicioDBML.WEB.DTOs;

namespace ExercicioDBML.WEB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransportadoraController : ControllerBase
    {
        private readonly ILogger<TransportadoraController> _logger;
        private readonly TransportadoraRepositorio _repositorio;
        public TransportadoraController(ILogger<TransportadoraController> logger, TransportadoraRepositorio repositorio)
        {
            _logger = logger;
           _repositorio = repositorio;
        }
        [HttpGet("ListarTodos")]
        public IActionResult ListarTransportadoras()
        {           
            return Ok(_repositorio.ListarTodos());
        }
        [HttpGet("{id}")]
        public IActionResult ListarTransportadorasPorId(int id)
        {            
            return Ok(_repositorio.ListarTodosPorId(id));
        }
        [HttpPost()]
        public IActionResult AdicionarTransportadora(TransportadoraDTO transportadoraDTO)
        {
            var transportadora = new Transportadora(transportadoraDTO.IdTransportadora, transportadoraDTO.Nome, transportadoraDTO.Telefone, transportadoraDTO.Email);
            _repositorio.Adicionar(transportadora);
            return Ok("Transportadora adicionada.");
        }
        [HttpPut()]
        public IActionResult AlterarDadosTransportadora(int id, string email)
        {
            _repositorio.AlterarEmailTransportadora(id, email);
            return Ok("Email alterado.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeletarTransportadoraPorId(int id)
        {
            _repositorio.Deletar(id);
            return Ok("Transportadora Removida.");
        }
    }
}