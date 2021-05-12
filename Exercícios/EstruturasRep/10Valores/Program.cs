using System;

namespace _10Valores
{
    class Program
    {
        static void Main(string[] args)
        {
//             Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.
            Console.WriteLine("Leitura de valores e amostra \n");
            double[] valores = new double [10]; 

            for (var i = 0; i < valores.Length; i++)
            {
                Console.Write($"Digite o {i + 1} valor: ");
                valores[i] = double.Parse(Console.ReadLine());             
            }

            Array.Sort(valores);
            Console.WriteLine($"\n O maior valor é {valores[9]}");
            Console.WriteLine($"\n O menor valor é {valores[0]}");
        }
    }
}
