using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
//             Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
// Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.
            Console.WriteLine("Tabuada \n");

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\n Tabuada do {i} \n");
                for (var a = 1; a <= 10; a++)
                {
                    int resultado = i * a;
                    Console.WriteLine($"{i} * {a} = {resultado}");
                }
            }
        }
    }
}
