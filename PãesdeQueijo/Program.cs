using System;

namespace PãesdeQueijo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] paodequeijo = null;
            Console.WriteLine("Quantos saquinhos de pão de queijo tem na prateleira?");
            int quantidadeSacos = int.Parse(Console.ReadLine());
            paodequeijo = new int[quantidadeSacos];

            for (var i = 0; i <= (quantidadeSacos -1); i++)
            {
                Console.WriteLine("Quantos pães de queijo tem no saco " + (i + 1));
                paodequeijo[i] = int.Parse(Console.ReadLine());
            }

            int c = 1;
            foreach (var item in paodequeijo)
            {
                Console.WriteLine("A quantidade de pães de queijo no saco " + c + " é " + item);
                c++;
            }
        }
    }
}
