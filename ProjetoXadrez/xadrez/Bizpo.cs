using System;
using tabuleiro;

namespace ProjetoXadrez.xadrez
{
    class Bizpo : Peca
    {
        public Bizpo(Tabuleiro tab, Cor cor)
            : base(tab, cor)
        {
        }

        public override bool[,] movimentosPossiveis()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
