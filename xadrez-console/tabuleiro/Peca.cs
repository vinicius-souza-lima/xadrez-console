using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro {
    internal class Peca {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QteMovimentos { get; set; }
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao,Tabuleiro tabuleiro, Cor cor) {
            Posicao = posicao;
            Cor = cor;
            QteMovimentos = 0;
        }
    }
}
