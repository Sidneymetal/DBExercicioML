using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ExercicioDBML.WEB.Controllers
{
    
    public class PedidosController
    {
        private readonly ILogger<PedidosController> _logger;
        private readonly PedidosController _context;

        public PedidosController(ILogger<PedidosController> logger, ExercicioMLContext context)
        {
            _logger = logger;
            _context = context;
        }
    }

}