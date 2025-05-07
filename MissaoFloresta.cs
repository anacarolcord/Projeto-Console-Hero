using System;

public class MissaoFloresta
{
    public void IniciarMissaoFloresta()
	{
        Console.Clear();
        Utils.EscreveComEfeito("Você encontra uma árvore falante....\n");
        Utils.EscreveComEfeito("A árvore te propõe um enigma....\n Ela diz:\n\n");
        Utils.EscreveComEfeito("Ei, jovem aventureira, me digas...\nVocê sabe o que é verde e fica no canto da sala?\n");

        Console.WriteLine("1- Um jacaré pensativo");
        Console.WriteLine("2- Uma samambaia");
        Console.WriteLine("3- O Hulk fazendo xixi\n");
        Utils.EscreveComEfeito("Digite o numero corre´spondente a sua escolha: \n");

        int resposta = int.Parse(Console.ReadLine());

        if (resposta == 2)
        {
            Utils.EscreveComEfeito("Resposta correta!!! A Árvore falante te entrega uma maçã dourada!\n");
        }
        else
        {
            Console.WriteLine("Errado!!! A árvore te transforma em planta.\n");
        }
    }
}
