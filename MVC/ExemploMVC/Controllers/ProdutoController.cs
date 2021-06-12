using ExemploMVC.Models;
using ExemploMVC.View;

namespace ExemploMVC.Controllers
{
    public class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos(){

            produtoView.Listar(produto.Ler());
        }

        public void CadastrarProdutos(){

            produto.Inserir(produtoView.Cadastrar());
            
        }
    }
}