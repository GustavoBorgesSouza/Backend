using System;

namespace PagamentoEcommerce.Classes
{
    public class Credito : Cartao
    {
        private float limite = 3000f;

        public void Pagar()
        {
            float valor = this.Valor;
            int vezes;

            if (valor > limite)
            {
                Console.WriteLine("Você não tem limite suficiente para efetuar a compra");
            } else {

                do
                {
                Console.WriteLine($"Em quantas vezes você deseja parcelar o valor {valor:C2}? de 1 a 12");
                vezes = int.Parse(Console.ReadLine());

                if (vezes >= 1 && vezes <= 6)
                {
                    Console.WriteLine($"Você optou por pagar o valor {valor:C2} em {vezes} parcelas, dessa forma terá 5% de juros do valor total");
                    Console.WriteLine($"Você pagará {valor * 1.05:C2} em {vezes} de {(valor * 1.05)/vezes:C2}");

                } else if (vezes >= 7 && vezes <= 12)
                {
                    Console.WriteLine($"Você optou por pagar o valor {valor:C2} em {vezes} parcelas, dessa forma terá 8% de juros do valor total");
                    Console.WriteLine($"Você pagará {valor * 1.08:C2} em {vezes} de {(valor * 1.08)/vezes:C2}");
                    
                } else{
                    Console.WriteLine("Impossível parcelar nessa quantidade, selecione um valor de 1 a 12");
                }
                    
                } while (vezes > 12 || vezes < 1);
            }

        }
    }
}