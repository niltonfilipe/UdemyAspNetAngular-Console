using System;

namespace GameTop.Lib
{
    public class Jogador1 : IJogador
    {
        public Jogador1(string nome)
        {
            this.Nome = nome;

        }
        public string Nome { get; }

        //Metodo Chutar para qualquer jogador
        public void Chutar()
        {
            Console.WriteLine($"{Nome} Chutou a bola");
        }

        //Metodo Passar
        public void Passar()
        {
            Console.WriteLine($"{Nome} Passou a bola");
        }

        //Metodo
        public void Correr()
        {
            Console.WriteLine($"{Nome} Corre atrás da bola");
        }
    }
}