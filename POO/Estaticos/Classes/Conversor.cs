namespace Estaticos.Classes
{
    public static class Conversor
    {
        private static float CotacaoDolar = 5.22f;

        public static float RealparaDolar(float valorRS){
            return valorRS / CotacaoDolar;
        }

        public static float DolarparaReal(float valorUS){
            return valorUS * CotacaoDolar;
        }

    }
}