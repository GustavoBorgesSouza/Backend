using System;
using System.Collections.Generic;
using ExemploMVC.Models;

namespace ExemploMVC.View
{
    public class ProdutoView
    {
        public void Listar(List<Produto> Listaprodutos){

            foreach (Produto item in Listaprodutos)
            {
                Console.WriteLine($"\nCodigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Codigo: {item.Preco:C2}");
                
            }
            
        }

        public Produto Cadastrar(){
            Produto produto = new Produto();

            Console.WriteLine($"Qual o codigo do produto?");
            produto.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Qual o nome do produto?");
            produto.Nome = Console.ReadLine();
            Console.WriteLine($"Qual o preço do produto?");
            produto.Preco = float.Parse(Console.ReadLine());

            return produto;
            
        }
    }
}