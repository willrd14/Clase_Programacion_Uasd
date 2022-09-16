//Factorial1.cs
using System;

class Factorial1
{
    static void Main()
    {
        //Declaracion de variables
        string mensaje = "Programa que calcula el factorial de un numero";
        int numero = 0, factorial = 1;

        //Pantalla
        Console.Clear();
        Console.WriteLine(mensaje);
        
        //Entrada de Datos
        Console.Write ("\nIntroduzca numero para calcular el factorial: ");
        numero = int.Parse(Console.ReadLine());

        //Proceso
        for (int i=1; i<=numero; i++)
        {
            factorial = factorial * i;

            Console.WriteLine("El factorial de {0} es {1}", numero,factorial);
        }
                
        //Salida
        Console.WriteLine("El factorial del número {0} es {1}", numero, factorial);
        Console.WriteLine("..................................");
        Console.ReadLine();
        
    }
}
