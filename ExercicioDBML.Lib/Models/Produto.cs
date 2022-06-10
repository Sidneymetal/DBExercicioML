namespace ExercicioDBML.Lib.Models

{
    public class Produto : ModelBase
    {        
        public int IdVendedor { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public Vendedor? Vendedor { get; set; }
        public List<ProdutoXPedido> ListaProdutosXPedidos { get; set; }
        public Produto() : base()
        {

        }
        public Produto(int id, int idVendedor, string nome, string descricao, Double valor, DateTime dataCadastro, Vendedor vendedor) : base(id)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
            DataCadastro = dataCadastro;
            Vendedor = vendedor;
        }
    }
}