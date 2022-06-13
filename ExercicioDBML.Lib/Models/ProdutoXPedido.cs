namespace ExercicioDBML.Lib.Models

{
    public class ProdutoXPedido : ModelBase
    {       
        public int IdProduto { get; set; }
        public int IdPedido { get; set; }
        public Produto? Produto { get; set; }
        public Pedido? Pedido { get; set; }

        public ProdutoXPedido() : base()
        {

        }
        public ProdutoXPedido(int id, int idProduto, int idPedido, Produto produto, Pedido pedido) : base(id)
        {
            Id = id;
            IdProduto = idProduto;
            IdPedido = idPedido;
            Produto = produto;
            Pedido = pedido;
        }        
    }
}