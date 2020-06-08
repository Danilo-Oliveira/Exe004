using System;

namespace ExeJoseInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ITela tela = new Player();

            tela.InformacaoJogador();
        }
    }
}
