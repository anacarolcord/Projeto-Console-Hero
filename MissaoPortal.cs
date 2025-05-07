using System;

public class MissaoPortal
{
    public void IniciarMissaoPortal()
	{
        Console.Clear();

        Utils.EscreveComEfeito("Você deverá conjurar um feitiço para abrir o portal mágico......\n\n");
        Utils.EscreveComEfeito("Digite a o feitiço que deseja conjurar: ");
        string feitiço = Console.ReadLine();

        Utils.EscreveComEfeito("Quantas vezes você deve dizer esse feitiço para que ele abra o portal?\n");
        Utils.EscreveComEfeito("Digite o numero de vezes: ");
        int vezes = int.Parse(Console.ReadLine());

        for (int i = 1; i <= vezes; i++)
        {
            Utils.EscreveComEfeito($" {i} - {feitiço}");
        }

        Utils.EscreveComEfeito("O portal foi aberto\n");
        Utils.EscreveComEfeitoLento("Atravessando.........\n");
        Utils.EscreveComEfeito("\n\nPressione ENTER para atravessar....");

        Console.ReadLine();
    }
}
