using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            string verificar;

            do
            {
                Console.Write("\n Digite o primeiro numero: ");
                double n1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                double n2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual operação você deseja realisar com os números? Digite +, -, * ou /");
                string operacao = Console.ReadLine();
                
                switch (operacao)
                {
                    case "+":
                    Console.WriteLine($"O resultado da soma é {Somar(n1,n2)}");
                        break;
                    case "-":
                    Console.WriteLine($"O resultado da subtração é {Subtrair(n1,n2)}");
                        break;
                    case "*":
                    Console.WriteLine($"O resultado da multiplicação é {Multiplicar(n1,n2)}");
                        break;
                    case "/":
                    Console.WriteLine($"O resultado da divisão é {Dividir(n1,n2)}");
                        break;
                    default:
                    Console.WriteLine("Essa não é uma operação valida, digite uma valida");
                        break;
                    
                }
                    Console.WriteLine("\n Você deseja realizar mais uma operação? (sim/nao)");
                    verificar = Console.ReadLine().ToLower();
                
            } while (verificar == "sim");

            Console.WriteLine("\n Tudo bem, espero que tenha atendido suas necessidades, até a proxima caro usuário :)");
        }

        static double Somar(double primeiroNumero, double segundoNumero )
        {
            double resultado = primeiroNumero + segundoNumero;
            return resultado;
        }

        static double Subtrair(double primeiroNumero, double segundoNumero)
        {
            double resultado = primeiroNumero - segundoNumero;
            return resultado;
        }
        static double Multiplicar(double primeiroNumero, double segundoNumero)
        {
            double resultado = primeiroNumero * segundoNumero;
            return resultado;
        }
        static double Dividir(double primeiroNumero, double segundoNumero)
        {
            double resultado = primeiroNumero / segundoNumero;
            return resultado;
        }


    }
}
