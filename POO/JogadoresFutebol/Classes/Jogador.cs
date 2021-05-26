using System;

namespace JogadoresFutebol.Classes
{
    public abstract class Jogador
    {
        public string nome{get; set;}
        public int diaNascimento{get; set;}
        public int mesNascimento{get; set;}
        public int anoNascimento{get; set;}
        public string nacionalidade{get; set;}
        public float altura{get; set;}
        public float peso{get; set;}
        public int idade{get; set;}

        public void PegarDados(){
            Console.WriteLine("Qual o nome do jogador?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual o dia de nascimento do jogador?");
             diaNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o mês de nascimento do jogador?");
            mesNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o ano de nascimento do jogador?");
            anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nacionalidade do jogador?");
            nacionalidade = Console.ReadLine();

            Console.WriteLine("Qual a altura do jogador?");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o peso do jogador?");
            peso = float.Parse(Console.ReadLine());
        }
        public void MostrarDados(){
            Console.WriteLine($@"Aqui estão os dados do jogador {nome}
            Data de nascimento: {diaNascimento}/{mesNascimento}/{anoNascimento}
            Nacionalidade: {nacionalidade}
            Altura: {altura}m
            Peso: {peso}kg");
        }

        public int CalcularIdade(){
            idade = DateTime.Now.Year - anoNascimento;
            return idade;
        }

        public virtual int CalcularAposentadoria(){
            int tempoFalta = idade;
            return tempoFalta;
        }
    }
}