using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Data;
namespace ExercicioDBML.WEB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TransportadoraController : ControllerBase
    {
        private readonly ILogger<TransportadoraController> _logger;
        private readonly ExercicioMLContext _context;

        public TransportadoraController(ILogger<TransportadoraController> logger, ExercicioMLContext context)
        {
            _logger = logger;
            _context = context;
        }
        public static void Main()
        {
        }
    }
}