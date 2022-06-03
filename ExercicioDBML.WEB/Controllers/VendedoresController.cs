using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ExercicioDBML.WEB.Controllers
{
    public class VendedoresController
    {
        private readonly ILogger<VendedoresController> _logger;
        private readonly VendedoresController _context;

        public VendedoresController(ILogger<VendedoresController> logger, VendedoresController context)
        {
            _logger = logger;
            _context = context;
        }
    }
}