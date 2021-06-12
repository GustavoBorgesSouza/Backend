using AulaPOO_ProjetoDeProdutos.Classes;

namespace AulaPOO_ProjetoDeProdutos.Interfaces
{
    public interface IProduto
    {
        void Cadastrar(Produto produtoCadastrar); 
        void Listar();
        void Deletar(Produto produtoDeletar);
    }
}