using System;

namespace PagamentoEcommerce.Classes
{
    public class Pagamento
    {
        private DateTime Data = DateTime.Now.Date;
        protected float Valor = 260f;

        public string Cancelar(){
            return "Pagamento Cancelado";
        }
    }
}