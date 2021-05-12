using System;

namespace CategoriasNatação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Categorias natação \n");
            Console.WriteLine("Olá nadador, qual sua idade?");
            double idade = double.Parse(Console.ReadLine());

                            // Feito com if
                            
            // if(idade > 5 && idade <= 7){
            //     Console.WriteLine("Você está na categoria Infantil A");
            // } else if(idade >= 8 && idade <=10){
            //     Console.WriteLine("Você está na categoria Infantil B");
            // } else if(idade >= 11 && idade <= 13){
            //  Console.WriteLine("Você está na categoria Juvenil A");
            // } else if(idade >= 14 && idade <= 17){
            //     Console.WriteLine("Você está na categoria Juvenil B");
            // } else{
            //     Console.WriteLine("Você está na categoria Sênior");
            // }



            switch (idade)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                Console.WriteLine("Você não pode nadar não amigão!!");
                    break;
                    
                case 5:
                case 6:
                case 7:
                Console.WriteLine("Você está na categoria Infantil A");
                    break;
                
                case 8:
                case 9:
                case 10:
                Console.WriteLine("Você está na categoria Infantil B");
                    break;

                case 11:
                case 12:
                case 13:
                Console.WriteLine("Você está na categoria Juvenil A");
                    break;

                case 14:
                case 15:
                case 16:
                Console.WriteLine("Você está na categoria Juvenil B");
                    break;

                default:
                Console.WriteLine("Você está na categoria Sênior");
                    break;
            }
            
        }
    }
}
