using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Init()
        {
        }

        [TestCase(1,2,3)]
        [TestCase(4,5,6)]
        [TestCase(7,8,9)]

        [TestCase(1,5,9)]
        [TestCase(3,4,7)]

        [TestCase(1,4,7)]
        [TestCase(2,5,9)]
        [TestCase(3,6,9)]
        public void Deve_Ganhar(int escolha1, int escolha2, int escolha3)
        {
            var tabuleiro = new Tabuleiro();
            var jogadorX = new JogadorX();
            var jogadorO = new JogadorO();
            jogadorX.Joga(tabuleiro, escolha1);
            jogadorX.Joga(tabuleiro, escolha2);
            jogadorX.Joga(tabuleiro, escolha3);
            
            Assert.AreEqual(tabuleiro.Jogando, false);
            Assert.AreEqual(tabuleiro.Ganhador, "Jogador X");
        }
    }
}
