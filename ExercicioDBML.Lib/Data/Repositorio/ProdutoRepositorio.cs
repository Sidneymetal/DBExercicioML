using ExercicioDBML.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace ExercicioDBML.Lib.Data.Repositorio;
public class ProdutoRepositorio : BaseRepositorio<Produto>
{
    public ProdutoRepositorio(ExercicioMLContext context) : base(context, context.Produtos)
    {

    }
    public List<Produto> ListarProdutosIncluindoVendedor()
    {
        return _dbset.AsNoTracking().Include(x => x.Vendedor).ToList();
    }
    public void AlterarValorProduto(int id, double valor)
    {
        var produto = _dbset.Find(id);
        produto.Valor = valor;
        _context.SaveChanges();
    }
}






