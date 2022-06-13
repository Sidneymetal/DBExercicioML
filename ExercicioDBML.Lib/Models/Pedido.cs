namespace ExercicioDBML.Lib.Models

{
    public class Pedido : ModelBase
    {       
        public int IdTransportadora { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataPedido{ get; set; }
        public string Status { get; set; }
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
            DataPedido = dataPedido;
            Status = status;
            Transportadora = transportadora;
            Cliente = usuario;
        }
        public void SetData(DateTime dataPedido)
        {
            ValidarDataAtual(dataPedido);
        }
        
        public void ValidarDataAtual(DateTime dataCadastro)
        {
            if (dataCadastro > DateTime.Now)
            {
                DataPedido = dataCadastro;
            }
        }
    }
}