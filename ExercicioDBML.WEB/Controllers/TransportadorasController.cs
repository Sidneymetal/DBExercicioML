using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ExercicioDBML.WEB.Controllers
{
    public class TransportadorasController
    {
        private readonly ILogger<TransportadorasController> _logger;
        private readonly TransportadorasController _context;

        public TransportadorasControllerr(ILogger<TransportadorasController> logger, TransportadorasController context)
        {
            _logger = logger;
            _context = context;
        }
    }
}