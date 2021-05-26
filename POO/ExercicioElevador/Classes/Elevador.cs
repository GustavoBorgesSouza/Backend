using System;

namespace ExercicioElevador.Classes
{
    public abstract class Elevador
    {
        protected int andarAtual;
        protected int totalAndares;
        protected int capacidade;
        protected int quantiaPessoas;

        public void Inicializar(){ //inicia o elevado dando o total de andares, capacidade, andar terreo e 0 pessoas
            andarAtual = 0;
            totalAndares = 2;
            capacidade = 2;
            quantiaPessoas = 0;
        }

        public virtual string Mostrar(){
            return $"O elevador está no {andarAtual} andar, tem {capacidade} de capacidade e tem {quantiaPessoas} pessoas";
        }

        public virtual int Entrar(){
            if (quantiaPessoas < capacidade)
            {
                Console.WriteLine($"Tinham {quantiaPessoas} no elevador, entrou 1 pessoa, agora temos {quantiaPessoas + 1} pessoas");
                quantiaPessoas = quantiaPessoas + 1;
            } else {
                Console.WriteLine($"O elevador está cheio, a capacidade de {capacidade} foi atingida");
            }

            return quantiaPessoas;
        }

        public int Sair(){
            if (quantiaPessoas > 0)
            {
                Console.WriteLine($"Tinham {quantiaPessoas} no elevador, saiu 1, agora temos {quantiaPessoas - 1} pessoas");
                quantiaPessoas = quantiaPessoas - 1;
            } else{
                Console.WriteLine("O elevador está vazio");
            }

            return quantiaPessoas;
        }

        public int Subir(){
            if(andarAtual < totalAndares){
                Console.WriteLine($"Estavamos no {andarAtual} andar, subimos 1 e agora estamos no {andarAtual + 1} andar");
                andarAtual = andarAtual + 1;
            } else{
                Console.WriteLine("Já estamos no último andar");
            }

            return andarAtual;
        }

        public int Descer(){
            if (andarAtual > 0)
            {
                Console.WriteLine($"Estavamos no {andarAtual} andar, descemos 1 e agora estamos no {andarAtual - 1} andar");
                andarAtual = andarAtual - 1;
            } else{
                Console.WriteLine("Já estamos no terreo");
            }

            return andarAtual;
        }
    }
}