namespace ExercicioDBML.Lib.Models
{
    public class Produtos
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public Vendedores Vendedor {get; set;}
        public int IdVendedor { get; set; }
        public List<ProdutosXPedidos> ProdutosXPedidos { get; set; }

    }
}