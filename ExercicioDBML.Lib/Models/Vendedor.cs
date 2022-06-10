namespace ExercicioDBML.Lib.Models

{
    public class Vendedor : ModelBase
    {       
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Produto> ListaProdutos { get; set; } = new List<Produto>();
        public Vendedor() : base()
        {

        }
        public Vendedor(int id, string nome, string email, string cnpj, DateTime dataCadastro) : base(id)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cnpj = cnpj;
            DataCadastro = dataCadastro;
        }
    }
}