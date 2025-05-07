using System;

public class InicioJogo
{
    public string nomeJogador;


    public void Inicio()
    {
        //BOAS VINDAS AO JOGADOR

        Utils.EscreveComEfeito("****** BEM-VINDA AO CONSOLE HERO ******");
        Utils.EscreveComEfeito("Qual é o seu nome, heroína?");
       
        nomeJogador = (Console.ReadLine());

    Utils.EscreveComEfeito($"\nSeja bem-vinda {nomeJogador}! Agora, escolha sua classe: ");


        Console.WriteLine("1- Guerreira");
        Console.WriteLine("2- Bruxa");
        Console.WriteLine("3- Hacker\n");

        Console.WriteLine("\nDigite o numero da sua classe: ");

        int escolhaClasse = int.Parse(Console.ReadLine());

    string classes = "";

        switch (escolhaClasse)
        {
            case 1:
                classes = "Guerreira";
                break;
            case 2:
                classes = "Bruxa";
                break;
            case 3:
                classes = "Hacker";
                break;
            default:
                classes = "Cidadã Comum - sem classe nenhuma";
                break;
        }

       Console.WriteLine($"Perfeito {nomeJogador}, você agora é uma {classes}\nPrepare-se para sua primeira missão.....\n");
    }

     public string ObterNome()
     {
         return nomeJogador;
     }
}






   

