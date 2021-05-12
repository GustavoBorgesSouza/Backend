using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algotimo Fibonacci");

            int numeroAnterior = -1;
            int proximoNumero = 1;
            int resultado;

           do
           {
            resultado = numeroAnterior + proximoNumero;

            numeroAnterior = proximoNumero;
            proximoNumero = resultado;

            Console.Write(resultado + ", ");
               
           } while (resultado < 500);

           Console.Write("Acabou! Passou de 500!!");



        //    for (var i = 0; i < 15; i++)
        //    {
        //     resultado = numeroAnterior + proximoNumero;

        //     numeroAnterior = proximoNumero;
        //     proximoNumero = resultado;

        //     Console.Write(resultado + ", ");
        //    }

        //    Console.Write("Acabou! Passou de 500!!");

        }
    }
}
