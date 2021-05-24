using System;

namespace PagamentoEcommerce.Classes
{
    public class Boleto : Pagamento
    {
        private string CodigoBarras;
        Random r = new Random();

        public void Registrar(){
            CodigoBarras = r.Next(3000000).ToString();
            Console.WriteLine($"O boleto foi gerado com o código {CodigoBarras} ");
            Console.WriteLine($"O boleto {CodigoBarras} registrado com desconto fica com um valor de {this.Valor * 0.88:C2}");
        }
    }
}