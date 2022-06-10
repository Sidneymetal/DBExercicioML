namespace ExercicioDBML.Lib.Models

{
    public class Pedido : ModelBase
    {       
        public int IdTransportadora { get; set; }
        public int IdUsuario { get; set; }
        public DateTime dataPedido{ get; set; }
        public string status { get; set; }
        public Transportadora? Transportadora { get; set; }
        public Usuario? Cliente { get; set; }
        public List<ProdutoXPedido> ListaProdutosXPedidos { get; set; } = new List<ProdutoXPedido>();

        public Pedido() : base()
        {
            
        }
        public Pedido(int id, int idTransportadora, int idUsuario, DateTime dataPedido, string status, Transportadora transportadora, Usuario usuario) : base (id)
        {
            Id = id;
            IdTransportadora = idTransportadora;
            IdUsuario = idUsuario;
            dataPedido = dataPedido;
            status = status;
            Transportadora = transportadora;
            Cliente = usuario;
        }
    }
}