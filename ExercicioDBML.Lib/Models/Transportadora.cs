using ExercicioDBML.Lib.Exceptions;

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
        public void SetEmail(string email)
        {
            if (ValidarEmail(email))
            {
                Email = email;
            }
        }
        public bool ValidarEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            throw new ExceptionsErroValidacao("O email deve conter @.");          
        }
        public void SetTelefone(string telefone)
        {
            if (ValidarTelefone(telefone))
            {
                Telefone = telefone;
            }
        }
        public bool ValidarTelefone(string telefone)
        {
            if (telefone.Length >= 10 && telefone.Length <= 11)
            {
                return true;
            }
            throw new ExceptionsErroValidacao("O telefone deve ter 10 à 11 caracteres.");
        }
    }
}