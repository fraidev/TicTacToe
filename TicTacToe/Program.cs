using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            var tabuleiro = new Tabuleiro();
            var jogadorX = new JogadorX();
            var jogadorO = new JogadorO();
            
            tabuleiro.ImprimaEscolha();

            
            while (tabuleiro.Jogando)
            {
                var x = int.Parse(Console.ReadLine());
                jogadorX.Joga(tabuleiro, x);
                tabuleiro.Imprima();
                if(!tabuleiro.Jogando) break;
                while (!tabuleiro.JogadaValida)
                {
                    x = int.Parse(Console.ReadLine());
                    jogadorX.Joga(tabuleiro, x);
                    tabuleiro.Imprima();
                    if(!tabuleiro.Jogando) break;
                }
                
                var y = int.Parse(Console.ReadLine());
                jogadorO.Joga(tabuleiro, y);
                tabuleiro.Imprima();
                if(!tabuleiro.Jogando) break;
                while (!tabuleiro.JogadaValida)
                {
                    y = int.Parse(Console.ReadLine());
                    jogadorO.Joga(tabuleiro, y);
                    tabuleiro.Imprima();
                    if(!tabuleiro.Jogando) break;
                }
            }
            Console.WriteLine("Fim De Jogo");
        }
    }
}
