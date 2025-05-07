using System;

public class MissaoCaverna
{
    public void IniciarMissaoCaverna()
	{

        Console.Clear();
        Utils.EscreveComEfeito("Você entrou na caverna e encontrou o morcego!\n\nM-m-mas.......\n\n Ele é GIGANTE!!!\n");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(@"
          /\                 /\
         /  \_____/  \
        (               )
         \___     ___/
             \   /
             (o o)
     ---oooO---(_)---Oooo--- 
    \n\n");
        Console.WriteLine("Morcegão: ");
        Utils.EscreveComEfeito("Testarei sua memória heroína... Decore a sequencia!");


        Random rnd = new Random();
        string[] sequencia = new string[5];
        string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        for (int i = 0; i < sequencia.Length; i++)
        {
            int index = rnd.Next(alfabeto.Length);
            sequencia[i] = alfabeto[index].ToString();

        }

        Console.WriteLine();

        foreach (string letra in sequencia)
        {
            Console.WriteLine(letra + "");
            Thread.Sleep(500);
        }

        Thread.Sleep(3000);
        Console.Clear();


        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("Morcegão: ");
        Utils.EscreveComEfeito("Digite a sequencia que você viu, separada por espaço:\n");
        Console.ResetColor();

        string resposta = Console.ReadLine();

        string sequenciaCerta = string.Join("", sequencia);

        if (resposta.Trim().ToUpper() == sequenciaCerta)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Utils.EscreveComEfeito("Hmmm... Sua mente é afiada como presas de vampiro! Avance!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Utils.EscreveComEfeito("HAHAHA! Você tem memória de peixe... E por falar em peixe.... Acho que agora você será o meu jantar!!!\n\n");
        }

        Console.ResetColor();

        Console.ReadLine();

    }
}
