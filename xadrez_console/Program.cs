﻿using tabuleiro;
using System;
using xadrez_console;
using xadrez;


try
{
    Tabuleiro tab = new Tabuleiro(8, 8);

    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
    tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 9));

    Tela.imprimirTabuleiro(tab);
}
catch (TabuleiroException ex) {
    Console.WriteLine(ex.Message);
}

