using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);

            tab.colocarPeca(new Torre(tab,Cor.Preta), new Posicao(2, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta) ,new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 4));

            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(4, 0));
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(5, 3));
            tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(7, 4));

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
