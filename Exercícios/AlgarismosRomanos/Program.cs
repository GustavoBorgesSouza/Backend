using System;

namespace AlgarismosRomanos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de 1 a 10 em algarismos romanos");
            string algarismoRoma = Console.ReadLine().ToUpper();


            switch (algarismoRoma)
            {
                case "I":
                Console.WriteLine(algarismoRoma + " é 1 em algarismos indo-arábicos");
                    break;

                case "II":
                Console.WriteLine(algarismoRoma + " é 2 em algarismos indo-arábicos");
                    break;
                case "III":
                Console.WriteLine(algarismoRoma + " é 3 em algarismos indo-arábicos");
                    break;

                case "IV":
                Console.WriteLine(algarismoRoma + " é 4 em algarismos indo-arábicos");
                    break;

                case "V":
                Console.WriteLine(algarismoRoma + " é 5 em algarismos indo-arábicos");
                    break;

                case "VI":
                Console.WriteLine(algarismoRoma + " é 6 em algarismos indo-arábicos");
                    break;

                case "VII":
                Console.WriteLine(algarismoRoma + " é 7 em algarismos indo-arábicos");
                    break;

                case "VIII":
                Console.WriteLine(algarismoRoma + " é 8 em algarismos indo-arábicos");
                    break;

                case "IX":
                Console.WriteLine(algarismoRoma + " é 9 em algarismos indo-arábicos");
                    break;

                case "X":
                Console.WriteLine(algarismoRoma + " é 10 em algarismos indo-arábicos");
                    break;
                
                default:
                Console.WriteLine("Isso aí não é algarismo romano de 1 a 10 não seu paspalhão!!");
                    break;
            }
            
        }
    }
}
