using System;

public class MenuPergaminho
{
    public void IniciarMenuPergaminho()
    {
        InicioJogo inicioJogo = new InicioJogo();
        string nomeJogador = inicioJogo.ObterNome();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@$"
╔══════════════════════════════════════╗
║                 PERGAMINHO           ║
║   Escolha seu destino, heroína:{nomeJogador}║
║                                      ║
║   1 - Beber uma poção misteriosa     ║
║   2 - Entrar em uma masmorra escura  ║
║   3 - Fugir pela janela da taverna   ║
╚══════════════════════════════════════╝
                                ");

        Console.ResetColor();



    }
}
