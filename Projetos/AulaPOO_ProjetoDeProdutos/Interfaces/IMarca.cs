using AulaPOO_ProjetoDeProdutos.Classes;

namespace AulaPOO_ProjetoDeProdutos.Interfaces
{
    public interface IMarca
    {
         void Cadastrar(Marca marcaCadastrar);

         void Listar();
         void Deletar(Marca marcaDeletar);


    }
}