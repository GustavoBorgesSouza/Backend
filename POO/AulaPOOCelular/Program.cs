using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            string destinatario;
            Celular BCell = new Celular();
            BCell.cor = "Preto";
            BCell.modelo = "xiaomi redmi note 9";
            BCell.tamanho = 6.53;
            Console.WriteLine("Olá, seu celular está desligado, deseja ligar? S/N");
            string desejo = Console.ReadLine().ToUpper();

            if (desejo == "S")
            {
                Console.WriteLine(BCell.Ligar());

            }
            else
            {
                Console.WriteLine("Tá bom, fica aí com o negócio desligado");
            }

            if (BCell.ligado == true)
            {

                do
                {

                    Console.WriteLine($@"
            __________________________________
            |         {BCell.modelo}     | 
            |         Especificações:        | 
            |      Tamanho: {BCell.tamanho}  | 
            |      Cor: {BCell.cor}              | 
            |                                | 
            |            Opções:             | 
            |                                | 
            |       1 - Fazer ligação        | 
            |       2 - Enviar mensagem      | 
            |       3 - Desligar             | 
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |                                | 
            |________________________________|");
                    Console.Write("\n Quer fazer oq?");
                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Console.Write("\n Quer ligar pra quem/qual número?");
                            destinatario = Console.ReadLine();

                            Console.WriteLine(BCell.Fazerligacao(destinatario));
                            break;

                        case "2":
                            Console.Write("\n Quer mandar mensagem pra quem/qual número?");
                            destinatario = Console.ReadLine();
                            Console.WriteLine("Que mensagem?");
                            string mensagem = Console.ReadLine();

                            Console.WriteLine(BCell.MandarMensagem(destinatario, mensagem));
                            break;

                        case "3":
                            BCell.Desligar();
                            Console.WriteLine("Tchau viu, até dps");
                            break;

                        default:
                            Console.WriteLine("Digite uma opção válida");
                            break;
                    }

                } while (BCell.ligado == true);



            }

        }
    }
}
