using GameTop.Lib;
using System;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo=new JogoBonito(new Jogador1("Messi"),new Jogador2("Ronaldo"));
            jogo.Iniciar();
        }
    }    
}
