using System;

public class MenuMissao
{

    public void IniciarMenuMissao()
    {
        Console.Clear();

        Utils.EscreveComEfeito("Você atravessou o portal e chegou em uma nova dimensão!!\n");
        Utils.EscreveComEfeito("Agora você possui três escolhas......");

        int escolha = -1;

        while (escolha != 0)
        {
            Utils.EscreveComEfeito("Escolha a sua ação com sabedoria...\n");
            Utils.EscreveComEfeito("1- Explorar a floresta misteriosa\n");
            Utils.EscreveComEfeito("2- Entrar na caverna sombria\n");
            Utils.EscreveComEfeito("3- Voltar para o mundo real (sair)\n");

            Console.WriteLine("Digite o numero da sua escolha:");
            bool entradaValida = int.TryParse(Console.ReadLine(), out escolha);

            if (!entradaValida)
            {
                Utils.EscreveComEfeito("Opçao invalidade, tente digitando um numero, derrrr\n");
                escolha = -1;
                continue;
            }
        }

        switch (escolha)
        {
            case 1:
                new MissaoFloresta().IniciarMissaoFloresta();
                break;
            case 2:
                new MissaoCaverna().IniciarMissaoCaverna();
                break;
            case 3:
                Utils.EscreveComEfeito("\n Você retornou para casa em segurança");
                break;
            default:
                Utils.EscreveComEfeito("Opção inválida, escolha e digite novamente");
                escolha = -1;
                break;
        }
    }
}



            


