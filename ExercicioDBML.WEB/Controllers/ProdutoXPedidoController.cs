using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Data;

namespace ExercicioDBML.WEB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoXPedidoController : ControllerBase
    {
        private readonly ILogger<ProdutoXPedidoController> _logger;
        private readonly ExercicioMLContext _context;

        public ProdutoXPedidoController(ILogger<ProdutoXPedidoController> logger, ExercicioMLContext context)
        {
            _logger = logger;
            _context = context;
        }
        public static void Main()
        {
        }
    }
}