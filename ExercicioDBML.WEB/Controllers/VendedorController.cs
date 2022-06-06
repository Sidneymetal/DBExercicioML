using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Data;
namespace ExercicioDBML.WEB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendedorController : ControllerBase
    {
        private readonly ILogger<VendedorController> _logger;
        private readonly ExercicioMLContext _context;

        public VendedorController(ILogger<VendedorController> logger, ExercicioMLContext context)
        {
            _logger = logger;
            _context = context;
        }
        public static void Main()
        {
        }
    }
}