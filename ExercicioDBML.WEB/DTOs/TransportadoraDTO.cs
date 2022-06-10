using ExercicioDBML.Lib.Models;

namespace ExercicioDBML.WEB.DTOs
{
    public class TransportadoraDTO
    {
        public int IdTransportadora { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<Pedido> ListaPedidos { get; set; }
    }
}