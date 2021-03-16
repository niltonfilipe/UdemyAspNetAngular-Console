using System;
namespace GameTop
{
    public class JogoBonito
    {
        public readonly IJogador nomeJogador1;
        public readonly IJogador nomeJogador2;
        public JogoBonito(IJogador _nome1,IJogador _nome2)
        {
            nomeJogador1=_nome1;
            nomeJogador2=_nome2;
        }
        public void Iniciar()
        {
            nomeJogador1.Correr();
            nomeJogador1.Passar();
            nomeJogador1.Chutar();

            Console.WriteLine("\nProximo \n");

            nomeJogador2.Correr();
            nomeJogador2.Passar();
            nomeJogador2.Chutar();
        }
    }
}