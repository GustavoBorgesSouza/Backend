using System;

namespace Combustível
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gastos com combustível \n");
            string verificar;

            do
            {
                Console.WriteLine("Quantos litros você deseja colocar?");
                double litros = int.Parse(Console.ReadLine());
                Console.WriteLine("Quantos combustível você deseja colocar? Digite A para álcool e G para gasolina");
                string combustivel = Console.ReadLine().ToUpper();
                double preco1;

                switch (combustivel)
                {
                    case "A":
                    preco1 = PrecoA(litros);

                    if (litros <= 20)
                    {
                        Console.WriteLine($"O preço a se pagar era de {PrecoA(litros)} é de {Desconto3(preco1, litros)}");
                    } else{
                        Console.WriteLine($"O preço a se pagar era de {PrecoA(litros)} e agora é de {Desconto5(preco1, litros)}");
                    }
                        break;

                    case "G":
                    preco1 = PrecoG(litros);

                    if (litros <= 20)
                    {
                        Console.WriteLine($"O preço a se pagar era de {PrecoG(litros)} e agora é de {Desconto4(preco1, litros)}");
                    } else{
                        Console.WriteLine($"O preço a se pagar era de {PrecoG(litros)} e agora é de {Desconto6(preco1, litros)}");
                    }
                        break;
                    default:
                    Console.WriteLine("Isso não é um combustível válido!");
                        break;
                }

                Console.WriteLine("\n Você deseja encher mais um veículo? (sim/nao)");
                verificar = Console.ReadLine().ToLower();
                
            } while (verificar == "sim");
            
            Console.WriteLine("Tudo bem, até a próxima chefia ;)");
        }

        static double PrecoA(double litros)
        {
            double preco1 = litros * 4.9; 
            return preco1;
        }
        static double PrecoG(double litros)
        {
            double preco1 = litros * 5.3; 
            return preco1;
        }
        static double Desconto3(double preco1, double litros)
        {
            double precoDesconto = preco1 - (litros * 0.03);
            return precoDesconto;
        }
        static double Desconto5(double preco1, double litros)
        {
            double precoDesconto = preco1 - (litros * 0.05);
            return precoDesconto;
        }
        static double Desconto4(double preco1, double litros)
        {
            double precoDesconto = preco1 - (litros * 0.04);
            return precoDesconto;
        }
        static double Desconto6(double preco1, double litros)
        {
            double precoDesconto = preco1 - (litros * 0.06);
            return precoDesconto;
        }
    }
}
