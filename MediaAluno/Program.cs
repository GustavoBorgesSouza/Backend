using System;

namespace ExemploConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome do aluno?");
            string nomeAluno = Console.ReadLine();
            Console.WriteLine("O aluno escolhido foi " + nomeAluno);

            Console.WriteLine("Qual foi a primeira nota de " + nomeAluno + "?");
            float Nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a segunda nota de " + nomeAluno + "?");
            float Nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a terceira nota de " + nomeAluno + "?");
            float Nota3 = int.Parse(Console.ReadLine()); 

            float media = (Nota1 + Nota2 + Nota3)/3;

            Console.WriteLine("A media de " + nomeAluno + " foi: " + Math.Round(media, 2).ToString());

            if(media>5){
                Console.WriteLine(nomeAluno + " foi Aprovado :)");
            } else{
                Console.WriteLine(nomeAluno + " foi Reprovado :(");
            }

        }
    }
}
