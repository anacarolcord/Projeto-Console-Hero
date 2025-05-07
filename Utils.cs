using System;

     public static class Utils
{
    public static void EscreveComEfeito(string texto, int velocidade = 50)
    {
        foreach (char c in texto)
        {
            Console.Write(c);
            Thread.Sleep(velocidade); // milissegundos
        }
        Console.WriteLine();
    }

    public static void EscreveComEfeitoLento(string texto, int velocidade = 150)
    {
        foreach (char c in texto)
        {
            Console.Write(c);
            Thread.Sleep(velocidade); // milissegundos
        }
        Console.ReadLine();
    }
}