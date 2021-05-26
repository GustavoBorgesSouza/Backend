namespace JogadoresFutebol.Classes
{
    public class Defesa : Jogador
    {
        public override int CalcularAposentadoria()
        {
            int tempoFalta;
            if (idade < 40)
            {
                tempoFalta = 40 - idade;
            } else{
                tempoFalta = 0;
            }
            return tempoFalta;
        }
    }
}