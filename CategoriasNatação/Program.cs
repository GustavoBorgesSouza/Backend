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

            if(idade > 5 && idade <= 7){
                Console.WriteLine("Você está na categoria Infantil A");
            } else if(idade >= 8 && idade <=10){
                Console.WriteLine("Você está na categoria Infantil B");
            } else if(idade >= 11 && idade <= 13){
                Console.WriteLine("Você está na categoria Juvenil A");
            } else if(idade >= 14 && idade <= 17){
                Console.WriteLine("Você está na categoria Juvenil B");
            } else{
                Console.WriteLine("Você está na categoria Sênior");
            }
        }
    }
}
