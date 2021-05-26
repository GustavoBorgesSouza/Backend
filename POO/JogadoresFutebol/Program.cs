using System;
using JogadoresFutebol.Classes;

namespace JogadoresFutebol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($@"Que tipo de jogador você quer verificar a idade e tempo que falta para se aposentar?
            D para defesa
            A para ataque
            M para meiocampo");
            string tipoJogador = Console.ReadLine().ToUpper();

            switch (tipoJogador)
            {
                case "D":
                    Defesa de = new Defesa();
                    de.PegarDados();
                    de.MostrarDados();

                    Console.WriteLine($"{de.nome} tem {de.CalcularIdade()} anos de idade");
                    Console.WriteLine($"Faltam {de.CalcularAposentadoria()} anos para {de.nome} se aposentar");
                    break;

                case "A":
                    Ataque a = new Ataque();
                    a.PegarDados();
                    a.MostrarDados();

                    Console.WriteLine($"{a.nome} tem {a.CalcularIdade()} anos de idade");
                    Console.WriteLine($"Faltam {a.CalcularAposentadoria()} anos para {a.nome} se aposentar");

                    break;

                case "M":
                    Meiocampo m = new Meiocampo();
                    m.PegarDados();
                    m.MostrarDados();
                    
                    Console.WriteLine($"{m.nome} tem {m.CalcularIdade()} anos de idade");
                    Console.WriteLine($"Faltam {m.CalcularAposentadoria()} anos para {m.nome} se aposentar");

                    break;

                default:
                    Console.WriteLine("Digite um tipo de jogador válido");
                    break;
            }
            

        }
    }
}
