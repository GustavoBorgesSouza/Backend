using System;

namespace ExercicioElevador.Classes
{
    public abstract class Elevador
    {
        protected int andarAtual;
        protected int totalAndares;
        protected int capacidade;
        protected int quantiaPessoas;

        public void Inicializar(int capacidadeD, int totalAndaresD){ //inicia o elevado dando o total de andares, capacidade, andar terreo e 0 pessoas
            andarAtual = 0;
            quantiaPessoas = 0;
            capacidade = capacidadeD;
            totalAndares = totalAndaresD;
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
            Console.WriteLine("Para qual andar você quer ir?");
            int andarIr = int.Parse(Console.ReadLine());

            if(andarIr < andarAtual){
                Console.WriteLine("Não dá para subir para baixo!");

            } else if (andarIr <= totalAndares) {

                Console.WriteLine($"Estavamos no {andarAtual} andar, subimos e agora estamos no {andarIr} andar");
                andarAtual = andarIr;
            } else{

                Console.WriteLine("Não é possível ir para esse andar!");
            }

            return andarAtual;
        }

        public int Descer(){
            Console.WriteLine("Para qual andar você quer ir?");
            int andarIr = int.Parse(Console.ReadLine());

            if(andarIr > andarAtual){
                Console.WriteLine("Não dá para descer para cima!");

            } else if (andarIr <= totalAndares && andarIr >= 0) {    

                Console.WriteLine($"Estavamos no {andarAtual} andar, descemos e agora estamos no {andarIr} andar");
                andarAtual = andarIr;
            } else {
                
                Console.WriteLine("Não é possível ir para esse andar!");
            }

            return andarAtual;
        }
    }
}