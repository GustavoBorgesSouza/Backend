using System;
using MetodosConstrutores.Classes;

namespace MetodosConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Métodos consturtores");

            Produto p1 = new Produto();
            Console.WriteLine($@"Informações produto1
            Código: {p1.Codigo}
            Nome: {p1.Nome}
            Descrição: {p1.Descricao}
            Quantia no estoque: {p1.Estoque}
            ");

            Produto p2 = new Produto(678);
            Console.WriteLine($@"Informações produto2
            Código: {p2.Codigo}
            Nome: {p2.Nome}
            Descrição: {p2.Descricao}
            Quantia no estoque: {p2.Estoque}
            ");

            Produto p3 = new Produto(267, "BANANA", "Bananas formosas, lindas e saborosas", 9);
            Console.WriteLine($@"Informações produto3
            Código: {p3.Codigo}
            Nome: {p3.Nome}
            Descrição: {p3.Descricao}
            Quantia no estoque: {p3.Estoque}
            ");
            
        }
    }
}
