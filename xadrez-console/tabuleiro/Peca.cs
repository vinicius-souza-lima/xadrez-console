namespace tabuleiro {
    internal class Peca {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QteMovimentos { get; set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor) {
            Posicao = null;
            Cor = cor;
            QteMovimentos = 0;
        }

        
    }
}
