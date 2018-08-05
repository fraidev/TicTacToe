namespace TicTacToe
{
    public class JogadorX:IJogador
    {
        public string Marca { get; set; } = "X";
        
        public void Joga(Tabuleiro tabuleiro, int escolha)
        {
            tabuleiro.Escolhe(escolha, Marca);
        }
    }
}