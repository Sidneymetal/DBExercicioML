namespace ExercicioDBML.Lib.Models

{
    public class Usuario : ModelBase
    {        
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }
        public List<Pedido> ListaPedidos { get; set; } = new List<Pedido>();
        public Usuario() : base()
        {

        }
        public Usuario(int id, string nome, string email, string cpf, DateTime dataNascimento, string senha) : base (id)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Senha = senha;
        }
    }
}
