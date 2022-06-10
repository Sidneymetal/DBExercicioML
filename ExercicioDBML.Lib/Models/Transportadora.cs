namespace ExercicioDBML.Lib.Models

{
    public class Transportadora : ModelBase
    {        
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<Pedido> ListaPedidos { get; set; } = new List<Pedido>();
        public Transportadora() : base()
        {

        }
        public Transportadora(int id, string nome, string telefone, string email) : base(id)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }
}