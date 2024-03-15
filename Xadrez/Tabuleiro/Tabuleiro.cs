using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas{ get; set; }

        public Tabuleiro() { }

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }
        public Peca peca(int linhas, int colunas)
        {
            return Pecas[linhas, colunas];
        }
        public void colocarPeca(Peca p, Posicao pos)
        {
            Pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;
        }
    }
}
