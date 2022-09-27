using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartidaDeXadrez partida = new();

            try
            {
                while (!partida.terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.imprimirPartida(partida);

                        Console.Write("\nOrigem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posiccoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posiccoesPossiveis);

                        Console.Write("\nDestino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                        partida.validarPosicaoDeDestino(origem, destino);

                        partida.realizaJogada(origem, destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Tela.imprimirPartida(partida);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Clear();
            Tela.imprimirPartida(partida);
            Console.ReadLine();
        }
    }
}
