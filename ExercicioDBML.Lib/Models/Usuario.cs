using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Data;
namespace ExercicioDBML.Lib.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Senha { get; set; }
        public List<Pedido> ListaPedidos { get; set; } = new List<Pedido>();
        public Usuario()
        {

        }
        public Usuario(int idUsuario, string nome, string email, string cpf, DateTime dataNascimento, string senha)
        {
            IdUsuario = idUsuario;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Senha = senha;
        }
    }
}
