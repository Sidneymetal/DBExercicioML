using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace ExercicioDBML.WEB.Controllers
{
    public class ProdutosXPedidosController
    {
        private readonly ILogger<ProdutosXPedidosController> _logger;
        private readonly ProdutosXPedidosController _context;

        public ProdutosXPedidosController(ILogger<ProdutosXPedidosController> logger, ProdutosXPedidosController context)
        {
            _logger = logger;
            _context = context;
        }
    }
}