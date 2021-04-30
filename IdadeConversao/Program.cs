using System;

namespace IdadeConversao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertor Idade \n");
            Console.WriteLine("Qual sua idade em anos?");
            double idadeAnos = double.Parse(Console.ReadLine());
            double idadeMeses = idadeAnos * 12;
            double idadeDias = idadeMeses * 30;
            double idadeHoras = idadeDias * 24;
            double idadeMinutos = idadeHoras * 60;

            Console.WriteLine("Sua idade em anos é: " + idadeAnos + ", em meses é: " + idadeMeses + ", em dias é: " + idadeDias + ", em horas é: " + idadeHoras + "e em minutos é: " + idadeMinutos);
            Console.WriteLine($@"Idade em:
            Anos:  {idadeAnos }
            Meses:  {idadeMeses}
            Dias:  {idadeDias}
            Horas:   {idadeHoras}
            Minutos:  {idadeMinutos}");
        }
    }
}
