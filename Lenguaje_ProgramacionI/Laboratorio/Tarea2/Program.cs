//-Imprima los Impares 1-100,

using System;

class Program
{
    static void Main()
    {
        Console.Clear();

        Console.WriteLine("Números impares del 1 al 100:");

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine(); // Espera a que el usuario presione Enter para salir.
    }
}
