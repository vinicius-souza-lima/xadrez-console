using System;

namespace tabuleiro {
    internal class Tabuleiro {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas) {
            Linhas = linhas;
            Colunas = colunas;
            pecas = new Peca[Linhas, Colunas];
        }

        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos) {
            return pecas[pos.linha, pos.coluna];
        }


        public bool posicaoValida(Posicao pos) {
            if (pos.linha < 0 || pos.linha >= Linhas || pos.coluna < 0 || pos.coluna >= Colunas)
                return false;
            return true;
        }

        public void validarPosicao(Posicao pos) {
            if (!posicaoValida(pos))
                throw new TabuleiroException("Posição Inválida!");
        }

        public bool existePeca(Posicao pos) {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos) {
            if (existePeca(pos)) {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public Peca retirarPeca(Posicao pos) {
            if (!existePeca(pos)) {
                return null;
            }

            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha,pos.coluna] = null;
            return aux;
        }



    }
}
