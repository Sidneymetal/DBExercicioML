namespace ExercicioDBML.Lib.Models
{
    public class Pedidos 
    {
        public string Id { get; set; }
        public DateTime DataPedidos { get; set; }
        public string Status { get; set; }        
        public int IdTransportadora { get; set; }        
        public int IdUsuario { get; set; }
        public List<ProdutosXPedidos> ProdutosXPedidos { get; set; }        
    }
}