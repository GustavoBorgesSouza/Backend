using System;

namespace PassagensAereas
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

            int[] passagens = new int[5];
            string[] nomeUser = new string[passagens.Length];
            string[] origem = new string[passagens.Length];
            string[] destino = new string[passagens.Length];
            int[] diaData = new int[passagens.Length];
            int[] mesData = new int[passagens.Length];
            int[] anoData = new int[passagens.Length];

            Console.WriteLine("\n Entrando no sistema \n");


            bool continuarSistema = true;
            int TotalPassagens = 0;
            var i = 0; //contador

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
                        string verificar;

                        do
                        {
                            Console.WriteLine("Quantas você quer cadastrar agora?");
                            int numeroPassagens = int.Parse(Console.ReadLine());
                            TotalPassagens = TotalPassagens + numeroPassagens;

                            if (TotalPassagens > 5)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine("Infelizmente só é possível cadastrar até 5 passagens");
                                TotalPassagens = TotalPassagens - numeroPassagens;
                                verificar = "nao";
                            }
                            else
                            {

                                do
                                {
                                    Console.Write($"\n Qual é o nome do passageiro {(i + 1)}? ");
                                    nomeUser[i] = Console.ReadLine();

                                    Console.Write($"\n Qual é a origem do passageiro {(i + 1)}? ");
                                    origem[i] = Console.ReadLine();

                                    Console.Write($"\n Qual é o destino do passageiro {(i + 1)}? ");
                                    destino[i] = Console.ReadLine();

                                    Console.Write($"\n Qual é o dia da viagem do passageiro {(i + 1)}? ");
                                    diaData[i] = int.Parse(Console.ReadLine());

                                    Console.Write($"\n Qual é o mês da viagem do passageiro {(i + 1)}? ");
                                    mesData[i] = int.Parse(Console.ReadLine());

                                    Console.Write($"\n Qual é o ano da viagem do passageiro {(i + 1)}? ");
                                    anoData[i] = int.Parse(Console.ReadLine());
                                    i++;
                                } while (i < numeroPassagens);

                                Console.WriteLine("\n Você quer cadastrar mais? (sim/nao)");
                                verificar = Console.ReadLine().ToLower();
                            }

                        } while (verificar == "sim");

                        break;

                    case "2":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        int c = 0;
                        Console.WriteLine("Aqui está a listagem de passagens: \n");
                        foreach (var item in passagens)
                        {
                            Console.WriteLine($@"
                        Informações:
                        Passageiro: {nomeUser[c]}
                        Origem: {origem[c]}
                        Destino: {destino[c]}
                        Data: {diaData[c]}/{mesData[c]}/{anoData[c]}");

                            c++;
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
