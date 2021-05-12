using System;

namespace Validaçãoinformações
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação de suas informações");

            bool nomeValido = false;
            do
            {
                Console.WriteLine("Qual seu nome?");
                string nome = Console.ReadLine();

                if (String.IsNullOrEmpty(nome))
                {
                    nomeValido = false;
                    Console.WriteLine("Nome inválido! \n DIgite um nome válido");
                } else
                {
                    nomeValido = true;
                }

            } while (nomeValido == false);

          Console.WriteLine("Esse nome é válido \n");

          bool idadeValida = false;
          do
          {
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade > 0 && idade <= 150)
            {
                idadeValida = true;
            }
            else
            {
                Console.WriteLine("Idade inválida! \n Digite uma idade válida");
            } 

          } while (idadeValida == false);

          Console.WriteLine("Essa é uma idade válida \n");

          bool salarioValido = false;
          do
          {
            Console.WriteLine("Qual seu salário?");
            double salario = double.Parse(Console.ReadLine());

            if (salario > 0)
            {
                salarioValido = true;
            }
            else
            {
                Console.WriteLine("Salário inválido! \n Digite um salário válido");
            }

          } while (salarioValido == false);

          Console.WriteLine("Esse salário é válido \n");

         bool estadocivilValido = false;
         do
         {
            Console.WriteLine($@" Qual seu estado Civil?
            Digite:
            s para solteiro(a)
            c para casado(a)
            d para divorciado(a)
            v para viuvo(a)");

            string estadocivil = Console.ReadLine();

            switch (estadocivil)
            {
                case "s":
                estadocivilValido = true;
                Console.WriteLine("Você é solteiro(a)");
                    break;

                case "c":
                estadocivilValido = true;
                Console.WriteLine("Você é casado(a)");
                    break;

                case "d":
                estadocivilValido = true;
                Console.WriteLine("Você é divorciado(a)");
                    break;

                case "v":
                estadocivilValido = true;
                Console.WriteLine("Você é viuvo(a)");
                    break;
                
                default:
                Console.WriteLine("Esse não é um estado civil válido \n Digite um que seja válido \n");
                    break;
            }
            
         } while (estadocivilValido == false);

         Console.WriteLine("\n Seu estado civil é válido \n Você está com tudo validado");
         Console.WriteLine("\n Fim do sistema");
        }
    }
}
