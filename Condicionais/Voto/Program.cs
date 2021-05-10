using System;

namespace Voto
{
    class Program
    {
        static void Main(string[] args)
        {
//             Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
// ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).
            Console.WriteLine("Verificação votos");
            Console.WriteLine("Em que ano você nasceu?");
            int anoNascimento = int.Parse(Console.ReadLine());
            int anoAtual = DateTime.Now.Year;
            int idade = anoAtual - anoNascimento;

            if (idade >= 18)
            {
                Console.WriteLine($"O ano é {anoAtual} e você deve votar, pois tem {idade} anos");
            } else if (idade >= 16)
            {
                Console.WriteLine($"O ano é {anoAtual} e você tem a opção de votar, pois tem {idade} anos");
            } else
            {
                Console.WriteLine($"O ano é {anoAtual} e você não tem idade suficiente para votar, pois tem {idade} anos");
            }

        }
    }
}
