using System;
using tabuleiro;
using xadrez_console;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Tabuleiro tab = new(8, 8);
            Tela.ImprimirTabuleiro(tab);
            Console.WriteLine();
        }
    }
}