using System;

namespace SistemaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de produtos \n");

            int tamanhoArray = 10;
            string[] nomeProdutos = new string[tamanhoArray];
            double[] precoProdutos = new double[tamanhoArray];
            bool[] promocaoProdutos = new bool[tamanhoArray];

            int i = 0;
            bool continuarSistema = true;
            string opcao;
            string cadastrarMais;

            do
            {
                MostrarMenu();
                Console.ForegroundColor = ConsoleColor.White;
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    do
                    {
                        CadastrarProdutos(nomeProdutos,precoProdutos,promocaoProdutos,i);
                        Console.WriteLine("Deseja cadastrar mais um? S/N");
                        cadastrarMais = Console.ReadLine().ToUpper();
                        i++;
                    } while (cadastrarMais == "S");
                        break;
                    
                    case "2":
                        Console.WriteLine("Aqui está a listagem de produtos: \n");
                    for (int c = 0; c < i; c++)
                    {
                        ListarProdutos(nomeProdutos, precoProdutos, promocaoProdutos, c);
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
                
            } while (continuarSistema);

        }

        static void MostrarMenu(){

            Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($@"O que você precisa fazer?           
            Menu:
            1 - Cadastrar produtos
            2 - Listar Produtos
            0 - Sair");
        }

        static int CadastrarProdutos(string[] nomeProdutos, double[] precoProdutos, bool[] promocaoProdutos, int i){
            Console.Write($"Qual o nome do produto {i + 1} ");
            nomeProdutos[i] = Console.ReadLine();
            Console.Write($"Qual o preço do produto {i + 1} ");
            precoProdutos[i] = double.Parse(Console.ReadLine());
            Console.Write($"O produto {nomeProdutos[i]} {i + 1} está em promoção? S/N ");
            string promocao = Console.ReadLine().ToUpper();

            if (promocao == "S")
            {
                promocaoProdutos[i] = true;
            } else{
                promocaoProdutos[i] = false;
            }

            i++;

            return i;
        }

        static void ListarProdutos(string[] nomeProdutos, double[] precoProdutos, bool[] promocaoProdutos, int c){
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($@"Informações produto {c + 1}:
            Nome: {nomeProdutos[c]}
            Preço: {precoProdutos[c]}
            Está em promoção? {promocaoProdutos[c]}
            true = está em promoção
            false = não está em promoção
            ");

            c++;
        }
    }
}
