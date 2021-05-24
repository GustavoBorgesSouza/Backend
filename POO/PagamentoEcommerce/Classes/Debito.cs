using System;

namespace PagamentoEcommerce.Classes
{
    public class Debito : Cartao
    {
        private float saldo = 600f;

        public void Pagar(){
            float valor = this.Valor;

            if (valor > saldo)
            {
                Console.WriteLine("Você não tem saldo suficiente");
            } else{
                Console.WriteLine($"O valor de {valor:C2} foi pago com sucesso");
            }
        }
    }
}