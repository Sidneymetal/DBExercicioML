using Microsoft.EntityFrameworkCore;
using ExercicioDBML.Lib.Data;
namespace ExercicioDBML.Lib.Models
{
    public class Vendedor
    {
        public int IdVendedor { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Produto> ListaProdutos { get; set; } = new List<Produto>();
        public Vendedor()
        {

        }
        public Vendedor(int idVendedor, string nome, string email, string cnpj, DateTime dataCadastro)
        {
            IdVendedor = idVendedor;
            Nome = nome;
            Email = email;
            Cnpj = cnpj;
            DataCadastro = dataCadastro;
        }
    }
}