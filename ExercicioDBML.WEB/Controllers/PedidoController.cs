using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Data;
namespace ExercicioDBML.WEB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly ILogger<PedidoController> _logger;
        private readonly ExercicioMLContext _context;

        public PedidoController(ILogger<PedidoController> logger, ExercicioMLContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        [HttpGet()]
        public IActionResult GetTodos()
        {
            var pedidos = _context.Pedidos.ToList();
            return Ok();
        }


    }

}