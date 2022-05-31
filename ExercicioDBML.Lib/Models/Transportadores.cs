namespace ExercicioDBML.Lib.Models
{
    public class Transportadores : Pedidos
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public List<Transporte> PegarPedidos {get; set;}
    }
}