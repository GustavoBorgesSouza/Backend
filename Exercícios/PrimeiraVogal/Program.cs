using System;

namespace PrimeiraVogal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos descobrir se a primeira letra do seu nome é uma vogal \n" + "Qual seu nome? \n");
            string nome = Console.ReadLine().ToLower();
            string letra = nome.Substring(0, 1);
  
            switch (letra)
            {
                case "a":
                Console.WriteLine("É vogal sim, a de amor");
                    break;
                case "e":
                Console.WriteLine("É vogal sim, e de escola");
                    break;
                case "i":
                Console.WriteLine("É vogal sim, i de ilha");
                    break;
                case "o":
                Console.WriteLine("É vogal sim, o de odirlei mestre");
                    break;
                case "u":
                Console.WriteLine("É vogal sim, u de ulisses");
                    break;
                case "t":
                Console.WriteLine("Bom, vogal não é, mas pelo menos começa igual ao do mestre thiago");
                    break;
                default:
                Console.WriteLine("Não é vogal não, meu amigo");
                    break;
            }
            
        }
    }
}
