using System;
using ExemploMVC.Controllers;
using ExemploMVC.Models;

namespace ExemploMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();

            prod.CadastrarProdutos();
            
            prod.ListarProdutos();
        }
    }
}
