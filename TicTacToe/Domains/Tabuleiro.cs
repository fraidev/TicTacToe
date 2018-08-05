using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    public  class Tabuleiro
    {
        public IList<string> Lugar { get; set; } = new List<string>();
        public bool Jogando { get; set; } = true;
        public bool JogadaValida { get; set; } = true;
        public string Ganhador { get; set; } = "";
        public string EstadoTabuleiro { get; set; } 
        public string EscolhaNoTabuleiro { get; set; } =  ("|------|------|------|\n"+
                                                           "|   1  |   2  |   3  |\n"+
                                                           "|------|------|------|\n"+
                                                           "|   4  |   5  |   6  |\n"+
                                                           "|------|------|------|\n"+
                                                           "|   7  |   8  |   9  |\n"+
                                                           "|------|------|------|\n");

        public Tabuleiro()
        {
            for(var i=0; i<10; i++)
            Lugar.Add(" ");
        }
        
        
        public void ImprimaEscolha()
        {
            Console.WriteLine(EscolhaNoTabuleiro);
        }
        
        public void Imprima()
        {
            EstadoTabuleiro = "|------|------|------|\n"+
                              $"|  {Lugar[1]}   |  {Lugar[2]}   |  {Lugar[3]}   |\n"+
                               "|------|------|------|\n"+
                              $"|  {Lugar[4]}   |  {Lugar[5]}   |  {Lugar[6]}   |\n"+
                               "|------|------|------|\n"+
                              $"|  {Lugar[7]}   |  {Lugar[8]}   |  {Lugar[9]}   |\n"+
                               "|------|------|------|\n";
            Console.WriteLine(EstadoTabuleiro);
        }

        public bool Ganhou()
        {
            if(Equals(Lugar[1], Lugar[2], Lugar[3])) return true;
            if(Equals(Lugar[4], Lugar[5], Lugar[6])) return true;
            if(Equals(Lugar[7], Lugar[8], Lugar[9])) return true;

            if(Equals(Lugar[1], Lugar[5], Lugar[9])) return true;
            if(Equals(Lugar[3], Lugar[4], Lugar[7])) return true;
            
            if(Equals(Lugar[1], Lugar[4], Lugar[7])) return true;
            if(Equals(Lugar[2], Lugar[5], Lugar[9])) return true;
            if(Equals(Lugar[3], Lugar[6], Lugar[9])) return true;
            
            return false;
        }

        private bool Equals(string a, string b, string c)
        {
            if (a == b && c == " ") return false;
            
            return a == b && c == a;
        }

        public void Escolhe(int escolha, string marca)
        {
            if (escolha < 10 && escolha > 0 && Lugar[escolha] == " ")
            {
                Lugar[escolha] = marca;
                JogadaValida = true;
            }
            else
            {
                Console.WriteLine($"Jogada Invalida, Jogue Novamente");
                JogadaValida = false;
            }
            
            if (Ganhou())
            {
                Jogando = false;
                Ganhador = "Jogador "+marca.ToUpper();
                Console.WriteLine($"{Ganhador} Ganhou");
            }
            
        }

    }
}