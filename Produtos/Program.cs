using System;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] produtos = null;
            Console.WriteLine("Quantas são as opções de produtos disponíveis?");
            int opcoesProdutos = int.Parse(Console.ReadLine());
            produtos = new int[opcoesProdutos];
            string[] nomeProdutos = null;
            nomeProdutos = new string[opcoesProdutos];

            for (var i = 0; i <= (opcoesProdutos -1); i++)
            {
                Console.WriteLine("Qual é o nome do produto " + (i + 1) + " ?");
                nomeProdutos[i] = Console.ReadLine();
            }

            int c = 1;
            // foreach (var item in nomeProdutos)
            // {
            //     Console.WriteLine("O produto " + c + " é " + item);
            //     c++;
            // }
            
            int[] quantidadeProdutos = null;
            quantidadeProdutos = new int[opcoesProdutos];
            c = 0;

            for (var i = 0; i <= (opcoesProdutos - 1); i++)
            {
                Console.WriteLine("Quantos " + nomeProdutos[c] + " tem no estabelecimento?");
                quantidadeProdutos[i] = int.Parse(Console.ReadLine());
                c++;
            }
            
            c = 0;

            // foreach (var item in quantidadeProdutos)
            // {
            //     Console.WriteLine("tem " + item + " " + nomeProdutos[c] + " no estabelecimento");
            //     c++;
            // }

            double[] precoProdutos = null;
            precoProdutos = new double[opcoesProdutos];

            c = 0;

            for (var i = 0; i <= (opcoesProdutos - 1); i++)
            {
                Console.WriteLine("Qual o preço de " + nomeProdutos[c] + "?");
                precoProdutos[i] = double.Parse(Console.ReadLine());
                c++;
            }

            c = 0;

            // foreach (var item in precoProdutos)
            // {
            //     Console.WriteLine("O preço de " + item + " é de " + nomeProdutos[c]);
            //     c++;
            // }

            Console.WriteLine(" \n Aqui estão as informações: \n");

            c = 0;
            foreach (var item in produtos)
            {
                Console.WriteLine($@"Produto:  {nomeProdutos[c]}
                
            Quantidade disponível no estabelecimento:  {quantidadeProdutos[c]}

            Preço do produto:  {precoProdutos[c]}" + "\n");

            c++;
            }

        }
    }
}
