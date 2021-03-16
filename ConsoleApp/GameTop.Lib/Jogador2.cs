using System;
namespace GameTop.Lib
{
    public class Jogador2 : IJogador
    {
        public Jogador2(string nome)
        {
            Nome = nome;
               
        }
        public readonly string Nome;

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