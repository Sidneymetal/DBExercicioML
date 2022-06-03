namespace ExercicioDBML.Lib.Models
{
    public class Vendedores
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Produtos> ListaProdutos { get; set; }
    }
}