namespace JogadoresFutebol.Classes
{
    public class Ataque : Jogador
    {
        public override int CalcularAposentadoria(){
            int tempoFalta;
            if (idade < 35)
            {
                tempoFalta = 35 - idade;
            } else{
                tempoFalta = 0;
            }
            return tempoFalta;
        }
    }
}