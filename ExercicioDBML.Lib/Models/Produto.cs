using ExercicioDBML.Lib.Exceptions;

namespace ExercicioDBML.Lib.Models;

public class Produto : ModelBase
{
    public int IdVendedor { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public double Valor { get; set; }
    public DateTime DataPedido { get; set; }
    public Vendedor? Vendedor { get; set; }
    public List<ProdutoXPedido> ListaProdutosXPedidos { get; set; }
    public Produto() : base()
    {

    }
    public Produto(int id, int idVendedor, string nome, string descricao, double valor, DateTime dataPedido, Vendedor vendedor) : base(id)
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
        Valor = valor;
        DataPedido = dataPedido;
        Vendedor = vendedor;
    }
    public void SetValor(double valor)
    {
        CalcularValor(valor);
        {
            Valor = valor;
        }
    }

    public void SetData(DateTime dataPedido)
    {
        ValidarDataAtual(dataPedido);
    }

    public void ValidarDataAtual(DateTime dataCadastro)
    {
        if (dataCadastro > DateTime.Now)
        {
            DataPedido = dataCadastro;
        }
        
    }
    public void CalcularValor(double valor)
    {
        if (valor > 0)
        {
            return;
        }       
    }
}