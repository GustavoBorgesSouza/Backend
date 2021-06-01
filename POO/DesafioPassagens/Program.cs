using System;
using System.Collections.Generic;
using DesafioPassagens.Classes;

namespace DesafioPassagens
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto passagens aéreas \n");
            bool senhaValida = false;

            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Digite a senha para entrar no sistema");
                int senha = int.Parse(Console.ReadLine());
                switch (senha)
                {
                    case 123456:
                        senhaValida = true;
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("\n Essa não é a senha válida, digite novamente");
                        break;
                }

            } while (senhaValida == false);

            List<Passagem> passagens = new List<Passagem>();

            Console.WriteLine("\n Entrando no sistema \n");


            bool continuarSistema = true;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($@"O que você precisa fazer? 
            Menu:
            1 - Cadastrar passagens
            2 - Listar Passagens
            0 - Sair");

                string sistema = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.White;

                switch (sistema)
                {
                    case "1":
                    Passagem p1 = new Passagem();
                    Console.WriteLine("Qual o nome do passageiro");
                    p1.nomePassageiro = Console.ReadLine();

                    Console.WriteLine("Qual a origem do passageiro");
                    p1.Origem = Console.ReadLine();

                    Console.WriteLine("Qual o destino do passageiro");
                    p1.Destino = Console.ReadLine();

                    Console.WriteLine("Qual o dia da viagem");
                    p1.DiaViagem = int.Parse(Console.ReadLine());

                    Console.WriteLine("Qual o mes da viagem");
                    p1.mesViagem = int.Parse(Console.ReadLine());

                    Console.WriteLine("Qual o ano da viagem");
                    p1.anoViagem = int.Parse(Console.ReadLine());

                    passagens.Add(p1);

                        break;

                    case "2":
                    foreach (Passagem item in passagens)
                    {
                        Console.WriteLine($@"
                        Informações:
                        Passageiro: {item.nomePassageiro}
                        Origem: {item.Origem}
                        Destino: {item.Destino}
                        Data: {item.DiaViagem}/{item.mesViagem}/{item.anoViagem}");
                    }
                        break;
                    
                    case "0":
                        continuarSistema = false;
                        Console.WriteLine("Ok, Estamos saindo do sistema, até a próxima :)");
                        break;
                    default:
                    Console.WriteLine("Essa não é uma das opções validas, digite uma válida!");
                        break;
                }
                

            } while (continuarSistema == true);
        }
    }
}
