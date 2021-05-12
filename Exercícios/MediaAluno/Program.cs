using System;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Media de alunos\n");
            Console.WriteLine("Qual o nome do aluno?");
            string nomeAluno = Console.ReadLine();
            Console.WriteLine("O aluno escolhido foi " + nomeAluno);

            Console.WriteLine("Qual foi a primeira nota de " + nomeAluno + "?");
            float Nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a segunda nota de " + nomeAluno + "?");
            float Nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual foi a terceira nota de " + nomeAluno + "?");
            float Nota3 = float.Parse(Console.ReadLine()); 

            float media = (Nota1 + Nota2 + Nota3)/3;

            Console.WriteLine(" ");
            Console.WriteLine("A media de " + nomeAluno + " foi: " + Math.Round(media, 2).ToString() + "\n");

            if(media>5){
                Console.WriteLine(nomeAluno + " foi Aprovado :)");
            } else{
                Console.WriteLine(nomeAluno + " foi Reprovado :(");
            }

        }
    }
}
