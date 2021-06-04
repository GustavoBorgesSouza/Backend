using System;
using CarrinhoCompras.Classes;

namespace CarrinhoCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carrinho de compras \n");

            Carrinho carrinho = new Carrinho();
            bool continuarSistema = true;
            int c = 0;
            int quantiaProdutos = 0;

            do
            {
                Console.WriteLine($@"O que você deseja fazer?
                1 - Adicionar produtos
                2 - Mostrar produtos
                3 - Remover produtos
                4 - Alterar produtos
                0 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":

                        c = quantiaProdutos + 1;
                        Console.WriteLine("Quantos produtos você vai adicionar?");

                        int quantiaProdutosAdd = int.Parse(Console.ReadLine());
                        int i = 1;

                        while (i <= quantiaProdutosAdd)
                        {
                            Console.WriteLine($"Vamos adicionar o produto {c} \n");

                            Console.WriteLine($"Qual é o nome do produto {c}?");
                            string nome = Console.ReadLine();
                            Console.WriteLine($"Qual é o preço do produto {c}?");
                            float preco = float.Parse(Console.ReadLine());

                            Produto p = new Produto(c, nome, preco);
                            carrinho.AdicionarProduto(p);
                            Console.WriteLine("\n");

                            c++;
                            i++;
                        }
                        quantiaProdutos += quantiaProdutosAdd;

                        break;

                    case "2":
                        carrinho.MostrarProdutos();
                        break;

                    case "3":
                        Console.WriteLine("Qual o código do produto que vc quer remover?");
                        int codigoRemover = int.Parse(Console.ReadLine());
                        carrinho.RemoverProduto(codigoRemover);
                        break;

                    case "4":
                        Console.WriteLine("Qual o codigo do produto que vc deseja alterar?");
                        int codigoAlterar = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Qual é o nome do novo produto?");
                        string nomeNovo = Console.ReadLine();
                        Console.WriteLine($"Qual é o preço do novo produto?");
                        float precoNovo = float.Parse(Console.ReadLine());

                        Produto pn = new Produto(0, nomeNovo, precoNovo);

                        carrinho.AlterarItem(codigoAlterar, pn);
                        break;

                    case "0":
                        Console.WriteLine("Certo, até depois meu amigo");
                        continuarSistema = false;
                        break;

                    default:
                        Console.WriteLine("Essa opção é invalida, digite novamente");
                        break;
                }


            } while (continuarSistema == true);
        }
    }
}
