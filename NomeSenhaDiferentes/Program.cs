using System;

namespace NomeSenhaDiferentes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificação nome e senha de usuário");

            Console.WriteLine("Olá, qual seu Nome de usuário?");
            string nomeUser = Console.ReadLine();
            Console.WriteLine("Qual é sua senha? (minímo 4 caracteres)");
            var senha = Console.ReadLine().ToString();
            int tamanhosenha = senha.Length;


            bool senhaValida = true;
            
            if (senha == nomeUser || tamanhosenha < 4)
                {
                    senhaValida = false;
                }

            while (senhaValida == false)
            {
                Console.WriteLine("Essa senha não é válida \n Digite uma senha válida(diferente do username e com no mínimo 4 caracteres) \n");
                senha = Console.ReadLine().ToString();
                tamanhosenha = senha.Length;
                // Console.WriteLine(senha + tamanhosenha);

                if (senha != nomeUser && tamanhosenha >= 4)
                {
                    senhaValida = true;
                }
            }
            
            Console.WriteLine("Essa senha é válida! \n Cadastro com sucesso");
            Console.WriteLine("Fim do sistema");
        }
    }
}
