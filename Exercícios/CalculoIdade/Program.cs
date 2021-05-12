using System;

namespace CalculoIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo Idade \n");
            Console.WriteLine("Qual o ano atual?");
            double anoAtual = double.Parse(Console.ReadLine());
            // double anoAtual = DateTime.Now.Year;
            Console.WriteLine("Em que ano você nasceu?");
            double anoNascimento = double.Parse(Console.ReadLine());
            double idade = anoAtual - anoNascimento;
            Console.WriteLine("\n Sua idade é:" + idade);

            double idadeSemana = idade * 52.143;
            Console.WriteLine("\n Sua idade em semanas é aproximadamente: " + idadeSemana);

        }
    }
}
