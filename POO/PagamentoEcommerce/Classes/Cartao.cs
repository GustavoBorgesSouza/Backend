using System;

namespace PagamentoEcommerce.Classes
{
    public abstract class Cartao : Pagamento
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;
        
        public string SalvarCartao(){
            Console.WriteLine("Qual é a bandeira do seu cartão?");
            bandeira = Console.ReadLine();

            Console.WriteLine("Qual é o número do seu cartão?");
            numero = Console.ReadLine();

            Console.WriteLine("Qual é o titular do seu cartão?");
            titular = Console.ReadLine();

            Console.WriteLine("Qual é o cvv do seu cartão?");
            cvv = Console.ReadLine();

            return $"Cartão de numero {numero} salvo com sucesso";
        }
    }
}