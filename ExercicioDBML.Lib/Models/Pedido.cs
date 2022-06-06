using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Data;
namespace ExercicioDBML.Lib.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdTransportadora { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataPedido { get; set; }
        public string StatusPedido { get; set; }
        public Transportadora Transportadora { get; set; }
        public Usuario Cliente { get; set; }
        public List<ProdutoXPedido> ListaProdutosXPedidos { get; set; } = new List<ProdutoXPedido>();

        public Pedido()
        {

        }

        public Pedido(int idPedido, int idTransportadora, int idUsuario, DateTime dataPedido, string statusPedido, Transportadora transportadora, Usuario usuario)
        {
            IdPedido = idPedido;
            IdTransportadora = idTransportadora;
            IdUsuario = idUsuario;
            DataPedido = dataPedido;
            StatusPedido = statusPedido;
            Transportadora = transportadora;
            Cliente = usuario;
        }
    }
}