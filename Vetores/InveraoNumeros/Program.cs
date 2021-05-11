using System;

namespace InveraoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inversão ordem 15 números \n");

            int[] valores = new int [3]; 

            for (var i = 0; i < valores.Length; i++)
            {
                Console.Write($"Digite o {i +1} valor: ");
                valores[i] = int.Parse(Console.ReadLine());
                
            }

            Console.WriteLine("\n Aqui estão os valores em ordem inversa \n");
            
            for (var i = (valores.Length - 1); i >= 0; i--)
            {
                Console.WriteLine(valores[i]);
            }
        }
    }
}
