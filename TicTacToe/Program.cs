using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var tabuleiro = new Tabuleiro();
            var jogador1 = new JogadorX();
            var jogador2 = new JogadorO();
            
            tabuleiro.ImprimaEscolha();

            while (tabuleiro.Jogando)
            {
                var x = int.Parse(Console.ReadLine());
                jogador1.Joga(tabuleiro, x);
                tabuleiro.Imprima();
                if (!tabuleiro.Jogando) break;
                
                var y = int.Parse(Console.ReadLine());
                jogador2.Joga(tabuleiro, y);
                tabuleiro.Imprima();
            }
            Console.WriteLine("Fim De Jogo");
        }
    }
}
