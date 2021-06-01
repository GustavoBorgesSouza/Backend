using System;
using System.Collections.Generic;
using ListasObjetos.Classes;

namespace ListasObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            //adicionar itens/objetos Create

            // Construindo na hora 
            produtos.Add(new Produto(1, "Apple watch", 3829.55f));
            produtos.Add(new Produto(2, "Mi band", 200.95f));
            produtos.Add(new Produto(3, "Samsung fit 2", 260.98f));
            produtos.Add(new Produto(4, "Amazfit", 494.95f));
            produtos.Add(new Produto(5, "Huawei watch fit", 768.23f));

            // produto já construido
            Produto SamsungActive = new Produto();
            SamsungActive.Nome = "Samgung watch active";
            SamsungActive.Codigo = 6;
            SamsungActive.Preco = 1248.90f;

            produtos.Add(SamsungActive);

            //Mostrar Read

                Console.WriteLine("\n Lista \n");

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"{item.Nome} custa {item.Preco:C2}");
            }

            // Update atualizar

            Produto atualizar  = produtos.Find(item => item.Nome == "Amazfit");
            atualizar.Preco = 240f;

            produtos.RemoveAll(item => item.Nome == "Amazfit");

            produtos.Insert(3, atualizar);

            //delete 

            produtos.RemoveAt(0);
            produtos.RemoveAll(item => item.Nome == "Mi band");

            // mostrar de novo

                Console.WriteLine("\n Lista \n");
                
            foreach (Produto item in produtos)
            {
                Console.WriteLine($"{item.Nome} custa {item.Preco:C2}");
            }

        }
    }
}
