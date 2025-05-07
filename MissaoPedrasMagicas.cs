using System;



public class MissaoPedrasMagicas
{
    public void IniciarMissaoPedrasMagicas()
	{

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
╔════════════════════════════════════════════╗
║           CAVERNA DOS NÚMEROS MÁGICOS      ║
║                                            ║
║  Três pedras brilham intensamente.         ║
║  Qual delas possui o MAIOR poder?          ║
╚════════════════════════════════════════════╝
");

        Console.ResetColor();

        Console.WriteLine("Digite o valor da pedra 1: ");
        int pedra1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da pedra 2: ");
        int pedra2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da pedra 3: ");
        int pedra3 = int.Parse(Console.ReadLine());

        int maior;

        if (pedra1 >= pedra2 && pedra1 >= pedra3)
        {
            maior = pedra1;
        }
        else if (pedra2 >= pedra1 && pedra2 >= pedra3)
        {
            maior = pedra2;
        }
        else
        {
            maior = pedra3;
        }

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine($"\n\nA Pedra com maior poder tem o valor {maior}");
        Console.WriteLine("A porta mágica se abre.....");
        Console.WriteLine("Você já pode seguir em frente:)");

        Console.ResetColor();
        Console.WriteLine("\n\nAperte ENTER para a próxima missão....");

        Console.ReadLine();
    }
}
