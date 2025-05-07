using System;

public class MissaoMenu
{
    public void IniciarMissaoMenu()
    {

        Console.Clear();
        Utils.EscreveComEfeito("Você encontra um pergaminho com três escolhas....");

        new MenuPergaminho().IniciarMenuPergaminho();

        Utils.EscreveComEfeito("Digite sua escolha: (1, 2 ou 3)");

        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                Utils.EscreveComEfeitoLento("Você bebeu a poção.... agora está falando em binário 0110010101 ahahahahaha ");
                break;
            case "2":
                Utils.EscreveComEfeitoLento("Você entra na masmorra e.......... encontra um bug ancestral (boa sorte)");
                break;
            case "3":
                Utils.EscreveComEfeitoLento("Você foge pela janela.... tropeça em um goblin e ...... ganha XP uhul");
                break;
            default:
                Console.WriteLine("Escolha inválida, o universo não entendeu o que você quer!!!");
                break;

        }

        Utils.EscreveComEfeito("\n\nAperte ENTER para a próxima missão....");

        Console.ReadLine();
    }
}
