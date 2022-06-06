using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Data;
namespace ExercicioDBML.WEB.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProdutoController : ControllerBase
    {
        private readonly ILogger<ProdutoController> _logger;
        private readonly ExercicioMLContext _context;

        public ProdutoController(ILogger<ProdutoController> logger, ExercicioMLContext context)
        {
            _logger = logger;
            _context = context;
        }
        public static void Main()
        {
        }
    }
}
