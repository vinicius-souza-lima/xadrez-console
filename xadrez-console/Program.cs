using System;
using tabuleiro;
using xadrez;

namespace xadrez_console {
    class Program {
        static void Main(string[] args) {
            try {
                Tabuleiro tab = new(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 7));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(3, 2));

                Tela.ImprimirTabuleiro(tab);
                Console.WriteLine();

                PosicaoXadrez pos = new('a', 1);
                Console.Write(pos.ToPosicao());
            }
            catch (TabuleiroException e) { 
                Console.WriteLine(e.Message);
            }
            
        }
    }
}