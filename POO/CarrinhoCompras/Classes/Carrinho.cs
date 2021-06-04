using System.Collections.Generic;
using System;
using CarrinhoCompras.Interfaces;

namespace CarrinhoCompras.Classes
{
    public class Carrinho : ICarrinho 
    {
        public float valorTotal{get; set;}

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        }

        public void RemoverProduto(int codigoRemover){
            carrinho.RemoveAll(item => item.Codigo == codigoRemover);
        }

        public void MostrarProdutos(){
            if (carrinho.Count > 0)
            {
                foreach (Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Produto {p.Nome} custa {p.Preco:C2} e tem codigo {p.Codigo}");
                    Console.ResetColor();
                }
                MostrarTotal();
            } else{
                Console.WriteLine("O carrinho está vazio");
            }
        }

        public void MostrarTotal(){
            if (carrinho.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                valorTotal = 0;  //reset no valor do carrinho
                foreach (Produto p in carrinho)
                {
                    valorTotal += p.Preco;
                }
                Console.WriteLine($"O valor total do carrinho é de {valorTotal:C2}");
            } else{
                Console.WriteLine("O carrinho está vazio");
            }
            Console.ResetColor();
        }

        public void AlterarItem(int _codigo, Produto novoProduto){
            carrinho.Find(x => x.Codigo == _codigo).Nome = novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = novoProduto.Preco;
        }
    }
}