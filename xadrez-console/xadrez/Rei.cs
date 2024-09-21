using tabuleiro;

namespace xadrez {
    internal class Rei : Peca {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { }
        public override string ToString() {
            return "R";
        }

        private bool PodeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor; // Só pode mover se não tiver peça ou for peça adversária
        }

        public override bool[,] MovimentosPossiveis() {

            bool[,] mat = new bool[tab.Linhas, tab.Colunas];
            Posicao pos = new(0, 0);

            // N
            pos.DefinirValores(posicao.linha - 1, posicao.coluna);
            if (tab.posicaoValida(pos) && PodeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }
            // NE
            pos.DefinirValores(posicao.linha - 1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && PodeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }
            // L
            pos.DefinirValores(posicao.linha, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && PodeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }
            // SE
            pos.DefinirValores(posicao.linha + 1, posicao.coluna + 1);
            if (tab.posicaoValida(pos) && PodeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }
            // S
            pos.DefinirValores(posicao.linha + 1, posicao.coluna);
            if (tab.posicaoValida(pos) && PodeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }
            // SO
            pos.DefinirValores(posicao.linha + 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && PodeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }
            // O
            pos.DefinirValores(posicao.linha, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && PodeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            // NO
            pos.DefinirValores(posicao.linha - 1, posicao.coluna - 1);
            if (tab.posicaoValida(pos) && PodeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }
    }
}
