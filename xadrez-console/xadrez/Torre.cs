using tabuleiro;

namespace xadrez {
    internal class Torre : Peca {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) { }
        public override string ToString() {
            return "T";
        }

        private bool PodeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor; // Só pode mover se não tiver peça ou for peça adversária
        }

        public override bool[,] MovimentosPossiveis() {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];
            Posicao pos = new(0, 0);

            // acima
            pos.DefinirValores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(pos) && PodeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.linha -= 1;
            }

            // abaixo
            pos.DefinirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(pos) && PodeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.linha += 1;
            }

            // direita
            pos.DefinirValores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && PodeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.coluna += 1;
            }

            // esquerda
            pos.DefinirValores(posicao.linha, posicao.coluna - 1);
            while (tab.posicaoValida(pos) && PodeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor) {
                    break;
                }
                pos.coluna -= 1;
            }

            return mat;
        }
    }
}
