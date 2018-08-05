namespace TicTacToe
{
    public class JogadorO:IJogador
    {
        public string Marca { get; set; } = "O";
        
        public void Joga(Tabuleiro tabuleiro, int escolha)
        {
            tabuleiro.Escolhe(escolha, Marca);
        }
    }
}