namespace ExercicioDBML.Lib.Models
{
    public class Usuarios : Pedidos
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }
    }
}