namespace ExercicioDBML.Lib.Models
{
    public class Produtos 
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdVendedor { get; set; }
    }
}