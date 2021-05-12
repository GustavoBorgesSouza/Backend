using System;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compras \n");
            string verificar;

            do
            {
                Console.WriteLine("Qual produto você escolheu?");
                string produto = Console.ReadLine();
                Console.WriteLine("Quantos você está levando?");
                int quantidade = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o preço unitário?");
                double valorUni = double.Parse(Console.ReadLine());

                double total = Total(quantidade, valorUni);

                if (quantidade <= 5)
                {
                    Console.WriteLine($"Você está levando {quantidade} {produto} que custa {valorUni} por unidade, o total original era {total} e com desconto ficou {Desconto2(total)}");
                }
                else if (quantidade > 5 && quantidade <= 10)
                {
                    Console.WriteLine($"Você está levando {quantidade} {produto} que custa {valorUni} por unidade, o total original era {total} e com desconto ficou {Desconto3(total)}");
                } 
                else
                {
                    Console.WriteLine($"Você está levando {quantidade} {produto} que custa {valorUni} por unidade, o total original era {total} e com desconto ficou {Desconto5(total)}");
                }

                Console.WriteLine("\n Você fazer outra compra? (sim/nao)");
                verificar = Console.ReadLine().ToLower();

            } while (verificar == "sim");

            Console.WriteLine("Tudo bem, até a próxima");
        }

        static double Total(int quantidade, double valorUni)
        {
            double total1 = quantidade * valorUni; 
            return total1;
        }
        static double Desconto2(double total1)
        {
            double totalReal = total1 * -0.98 * -1; 
            return totalReal;
        }
        static double Desconto3(double total1)
        {
            double totalReal = total1 * -0.97 * -1; 
            return totalReal;
        }
        static double Desconto5(double total1)
        {
            double totalReal = total1 * -0.95 * -1; 
            return totalReal;
        }
    }
}
