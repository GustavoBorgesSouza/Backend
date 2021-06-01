using System;
using Estaticos.Classes;

namespace Estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão");
            Console.WriteLine("Você quer converter de real para dolar ou de dolar para real? DIgite 1 para a primeira e 2 para a segunda opção");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                Console.WriteLine("Quantos reais vc tem?");
                float valorRS = float.Parse(Console.ReadLine());
                Console.WriteLine(Conversor.RealparaDolar(valorRS));
                    break;

                case 2:
                Console.WriteLine("Quantos Dolares vc tem?");
                float valorUS = float.Parse(Console.ReadLine());
                Console.WriteLine(Conversor.DolarparaReal(valorUS));
                    break;
                
                default:
                Console.WriteLine("Essa opção não é válida");
                    break;
            }
            
        }
    }
}
