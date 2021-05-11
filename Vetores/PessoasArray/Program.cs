using System;

namespace PessoasArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificação pessoas em um array \n");

            string[] nomePessoas = new string[10];

            for (var i = 0; i < nomePessoas.Length; i++)
            {
                Console.WriteLine("Digite o nome " + (i + 1));
                nomePessoas[i] = Console.ReadLine();
            }

            string verificar;

            do
            {
                Console.WriteLine("Digite um nome para buscar");
                string nome = Console.ReadLine();

                bool existe = false;

                foreach (var item in nomePessoas)
                {
                    if (item == nome)
                    {
                        existe = true;
                    }
                }

                if (existe == true)
                {
                    Console.WriteLine("ACHEI");
                }
                else
                {
                    Console.WriteLine("NÂO ACHEI");
                }

                Console.WriteLine("\n deseja verificar outro nome? sim/nao");
                verificar = Console.ReadLine().ToLower();

            } while (verificar == "sim");

            Console.WriteLine("Ok, até a proxima");
        }
    }
}
