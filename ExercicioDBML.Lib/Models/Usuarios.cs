namespace ExercicioDBML.Lib.Models
{
    public class Usuarios
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }
        public List<Pedidos> PegarPedidos { get; set; }
    }
}