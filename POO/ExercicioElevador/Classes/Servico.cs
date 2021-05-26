using System;

namespace ExercicioElevador.Classes
{
    public class Servico : Elevador
    {
        private int quantiaCaixas;

        public override string Mostrar(){
            return $"O elevador está no {andarAtual} andar, tem {capacidade} de capacidade, tem {quantiaPessoas} pessoas e {quantiaCaixas} caixas";
        }

        public override int Entrar(){
            if (quantiaPessoas + quantiaCaixas < capacidade)
            {
                Console.WriteLine($"Tinham {quantiaPessoas} no elevador, entrou 1 pessoa, agora temos {quantiaPessoas + 1} pessoas");
                quantiaPessoas = quantiaPessoas + 1;
            } else {
                Console.WriteLine($"O elevador está cheio, a capacidade de {capacidade} foi atingida");
            }

            return quantiaPessoas;
        }
        public int Colocar(){
            if (quantiaCaixas + quantiaPessoas < capacidade)
            {
                Console.WriteLine($"Tinham {quantiaCaixas} caixas no elevador, {quantiaPessoas} pessoas no elevador, colocaram uma caixa agora temos {quantiaCaixas + 1} caixas");
                quantiaCaixas = quantiaCaixas + 1;
            } else{
                Console.WriteLine($"O elevador está cheio, a capacidade de {capacidade} foi atingida");
            }

            return quantiaCaixas;
        }
        public int Tirar(){
            if (quantiaCaixas > 0)
            {
                Console.WriteLine($"Tinham {quantiaCaixas} caixas no elevador, {quantiaPessoas} pessoas no elevador, tiraram uma caixa agora temos {quantiaCaixas - 1} caixas");
                quantiaCaixas = quantiaCaixas - 1;
            } else{
                Console.WriteLine($"O elevador não tem caixas");
            }

            return quantiaCaixas;
        }

        


    }
}