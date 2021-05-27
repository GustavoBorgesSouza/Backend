using System;
using JogadoresFutebol.Classes;

namespace JogadoresFutebol
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogadorValido = false;

            do
            {
                Console.WriteLine($@"Que tipo de jogador você quer verificar a idade e tempo que falta para se aposentar?
            D para defesa
            A para ataque
            M para meiocampo");
                string tipoJogador = Console.ReadLine().ToUpper();
                string opcao;

                switch (tipoJogador)
                {
                    case "D":
                    jogadorValido = true;
                        Defesa de = new Defesa();
                        de.PegarDados();

                        Console.WriteLine($@"O que vc deseja?
                        1 - mostrar dados
                        2 - mostrar idade
                        3 - calcular tempo que falta para aposentadoria");
                        opcao = Console.ReadLine();
                
                        switch (opcao)
                        {
                            case "1":
                            de.MostrarDados();
                                break;
                            case "2":
                            Console.WriteLine($"{de.nome} tem {de.CalcularIdade()} anos de idade");
                                break;
                            case "3":
                            Console.WriteLine($"Faltam {de.CalcularAposentadoria()} anos para {de.nome} se aposentar");
                                break;
                            default:
                            Console.WriteLine("Essa opção é inválida");
                                break;
                        }
                        
                        break;

                    case "A":
                    jogadorValido = true;
                        Ataque a = new Ataque();
                        a.PegarDados();

                        Console.WriteLine($@"O que vc deseja?
                        1 - mostrar dados
                        2 - mostrar idade
                        3 - calcular tempo que falta para aposentadoria");
                        opcao = Console.ReadLine();
                
                        switch (opcao)
                        {
                            case "1":
                            a.MostrarDados();
                                break;
                            case "2":
                            Console.WriteLine($"{a.nome} tem {a.CalcularIdade()} anos de idade");
                                break;
                            case "3":
                            Console.WriteLine($"Faltam {a.CalcularAposentadoria()} anos para {a.nome} se aposentar");
                                break;
                            default:
                            Console.WriteLine("Essa opção é inválida");
                                break;
                        }

                        break;

                    case "M":
                    jogadorValido = true;
                        Meiocampo m = new Meiocampo();
                        m.PegarDados();

                        Console.WriteLine($@"O que vc deseja?
                        1 - mostrar dados
                        2 - mostrar idade
                        3 - calcular tempo que falta para aposentadoria");
                        opcao = Console.ReadLine();
                
                        switch (opcao)
                        {
                            case "1":
                            m.MostrarDados();
                                break;
                            case "2":
                            Console.WriteLine($"{m.nome} tem {m.CalcularIdade()} anos de idade");
                                break;
                            case "3":
                            Console.WriteLine($"Faltam {m.CalcularAposentadoria()} anos para {m.nome} se aposentar");
                                break;
                            default:
                            Console.WriteLine("Essa opção é inválida");
                                break;
                        }

                        break;

                    default:
                    Console.WriteLine("Digite um tipo de jogador válido \n");
                    jogadorValido = false;
                        break;

                } 

            } while(!jogadorValido);



        }
    }
}
