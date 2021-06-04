using CarrinhoCompras.Classes;

namespace CarrinhoCompras.Interfaces
{
    public interface ICarrinho
    {
         void AdicionarProduto(Produto produto);

         void RemoverProduto(int codigoRemover);

         void MostrarProdutos();

         void MostrarTotal();

         void AlterarItem(int _codigo, Produto novoProduto);
    }
}