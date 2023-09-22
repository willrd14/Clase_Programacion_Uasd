using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculadora básica en C#");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            // Leemos la opción ingresada por el usuario
            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Opción no válida. Por favor, ingrese un número del 1 al 5.");
                continue;
            }

            // Realizamos la operación correspondiente
            double resultado = 0.0;
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el primer número: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());
                    resultado = num1 + num2;
                    break;
                case 2:
                    Console.Write("Ingrese el primer número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 - num2;
                    break;
                case 3:
                    Console.Write("Ingrese el primer número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 * num2;
                    break;
                case 4:
                    Console.Write("Ingrese el numerador: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el denominador: ");
                    num2 = double.Parse(Console.ReadLine());

                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: División por cero.");
                        continue;
                    }

                    resultado = num1 / num2;
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa.");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Por favor, ingrese un número del 1 al 5.");
                    continue;
            }

            Console.WriteLine("El resultado es: " + resultado);
            Console.WriteLine();
        }
    }
}

