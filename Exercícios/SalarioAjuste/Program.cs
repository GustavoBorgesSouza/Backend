using System;

namespace SalarioAjuste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ajuste salarial \n");
            Console.WriteLine("Olá funcionário, qual seu nome?");
            string nomeFuncionario = Console.ReadLine();
            Console.WriteLine(nomeFuncionario + " qual seu salário?");
            double salario = double.Parse(Console.ReadLine());

            if (salario < 500)
            {
                double salarioAjustado = salario + salario * 0.3;
                Console.WriteLine(nomeFuncionario + " seu salário reajustado é de: " + salarioAjustado);
            }
            else
            {
                Console.WriteLine(nomeFuncionario + " você não tem direito a aumento");
            }
        }
    }
}
