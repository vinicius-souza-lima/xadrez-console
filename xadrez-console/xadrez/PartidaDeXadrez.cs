using System;
using tabuleiro;

namespace xadrez {
    internal class PartidaDeXadrez {
        public Tabuleiro Tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada {  get; private set; }

        public PartidaDeXadrez() {
            Tab = new(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Posicao origem, Posicao destino) {
            Peca p = Tab.retirarPeca(origem);
            p.incrementarQteMovimentos();
            Peca pecaCapturada = Tab.retirarPeca(destino);
            Tab.colocarPeca(p,destino);
        }

        public void colocarPecas() {
            Tab.colocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('c',1).ToPosicao());
            Tab.colocarPeca(new Torre(Tab, Cor.Preta), new PosicaoXadrez('c', 2).ToPosicao());
            Tab.colocarPeca(new Rei(Tab, Cor.Preta), new PosicaoXadrez('c', 3).ToPosicao());

            Tab.colocarPeca(new Torre(Tab, Cor.Branca), new PosicaoXadrez('c', 4).ToPosicao());
        }

    }
}
