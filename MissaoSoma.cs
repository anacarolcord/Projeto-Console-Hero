using System;

public class MissaoSoma
{
    public void IniciarMissaoSoma()
	{
        Utils.EscreveComEfeito("Missão 1 - A Soma Sagrada!");
        Utils.EscreveComEfeito("Você encontrou um cofre antigo... e ele tem um engima...\n\nPara abri-lo você precisa somar dois numeros mágicos...\n");
        Utils.EscreveComEfeito("Digite o primeiro numero: ");

        int num1 = int.Parse(Console.ReadLine());

        Utils.EscreveComEfeito("Digite o segundo numero: ");

        int num2 = int.Parse(Console.ReadLine());

        int resultadoSoma = num1 + num2;

        Utils.EscreveComEfeito($"A soma é {resultadoSoma}");
        Console.WriteLine("\n**********************************************************");
        Utils.EscreveComEfeito("Parabéns, o cofre se abriu, você ganhou um Elixir da Lógica");
        Console.WriteLine("************************************************************\n");

        Utils.EscreveComEfeito("Aperte ENTER para a próxima missão....");
        Console.ReadLine();
    }
}
