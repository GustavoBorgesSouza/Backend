using System;
using ExercicioElevador.Classes;

namespace ExercicioElevador
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuarB = false;
            bool elevadorValido = false;



            do
            {

            Console.WriteLine("Você deseja usar qual elevador? SO para social e SE par serviço");
            string elevador = Console.ReadLine().ToUpper();

            switch (elevador)
            {
                case "SO":
                    Social s = new Social();
                    s.Inicializar();
                    elevadorValido = true;

                    do
                    {
                        Console.WriteLine($@" Você está no social
                        {s.Mostrar()}
                        O que você deseja fazer?

                        E - Entrar uma pessoa
                        S - Sair uma pessoa
                        Su - Subir
                        D - Descer");

                        string opcao = Console.ReadLine().ToUpper();

                        switch (opcao)
                        {
                            case "E":
                                s.Entrar();
                                break;

                            case "S":
                                s.Sair();
                                break;

                            case "SU":
                                s.Subir();
                                break;

                            case "D":
                                s.Descer();
                                break;

                            default:
                                Console.WriteLine("Essa opcao é invalida, digite uma valida");
                                break;
                        }

                        Console.WriteLine("Deseja continuar? s para sim");
                        string continuar = Console.ReadLine().ToLower();

                        if (continuar == "s")
                        {
                            continuarB = true;
                        }
                        else
                        {
                            continuarB = false;
                        }

                    } while (continuarB == true);

                    break;

                case "SE":
                    Servico se = new Servico();
                    se.Inicializar();
                    elevadorValido = true;

                    do
                    {
                        Console.WriteLine($@" Você está no de serviço
                        {se.Mostrar()}
                        O que você deseja fazer?

                        E - Entrar uma pessoa
                        S - Sair uma pessoa
                        C - Colocar caixa
                        T - Tirar caixa
                        SU - Subir
                        D - Descer");

                        string opcao = Console.ReadLine().ToUpper();

                        switch (opcao)
                        {
                            case "E":
                                se.Entrar();
                                break;

                            case "S":
                                se.Sair();
                                break;

                            case "C":
                                se.Colocar();
                                break;

                            case "T":
                                se.Tirar();
                                break;

                            case "SU":
                                se.Subir();
                                break;

                            case "D":
                                se.Descer();
                                break;

                            default:
                                Console.WriteLine("Essa opcao é invalida, digite uma valida");
                                break;
                        }

                        Console.WriteLine("Deseja continuar? s para sim");
                        string continuar = Console.ReadLine().ToLower();

                        if (continuar == "s")
                        {
                            continuarB = true;
                        }
                        else
                        {
                            continuarB = false;
                        }

                    } while (continuarB == true);

                    break;

                default:
                Console.WriteLine("Não temos essa opção de elevador nesse edificio, talvez você deva ir a outro, desculpe lhe causar incomodo");
                elevadorValido = false;
                    break;
            }
                
            } while (elevadorValido == true);



        }
    }
}
