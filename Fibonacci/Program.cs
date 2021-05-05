using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algotimo Fibonacci");

            int primeiroValor = 0;
            int segundoValor = primeiroValor + 1;
            int resultado1 = primeiroValor + segundoValor;

            bool fazer = true;
            do
            {
                primeiroValor = segundoValor;
                segundoValor = resultado1;
                int resultado = primeiroValor + segundoValor;

                Console.WriteLine(resultado);
                if (resultado > 500)
                {
                    fazer = false;
                }
            } while ( fazer == true);
        }
    }
}
