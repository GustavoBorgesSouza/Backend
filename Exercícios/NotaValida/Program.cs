using System;

namespace NotaValida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação de notas entre 0 a 10 \n");

            bool notaValida = false;

            do
            {
                Console.WriteLine("Qual é a nota que vc recebeu?");
                int nota = int.Parse(Console.ReadLine());

                if (nota > 0 && nota <= 10)
                {
                notaValida = true; 
                Console.WriteLine("Sua nota é valida e é igual a: " + nota + "\n");
                } else
                {
                notaValida = false;
                Console.WriteLine("Essa não é uma nota válida! \n Digite uma nota de 0 a 10 \n");
                }
                
            } while (notaValida == false);

            Console.WriteLine("Fim do sistema");
        }
    }
}
