namespace TicTacToe
{
    public interface IJogador
    {
        string Marca { get; set; }
        void Joga(Tabuleiro tabuleiro, int escolha);
    }
}