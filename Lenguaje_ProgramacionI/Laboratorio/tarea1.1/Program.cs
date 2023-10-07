using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Ingrese el monto disponible en dólares: ");
        int cantidadDinero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el precio del artículo en dólares: ");
        int precioArticulo = Convert.ToInt32(Console.ReadLine());

        int[] monedas = new int[] { 25, 10, 5, 1 }; // Valores de las monedas

        if (precioArticulo > cantidadDinero)
        {
            Console.WriteLine("El precio del artículo es mayor que la cantidad de dinero disponible.");
        }
        else if (precioArticulo < 0)
        {
            Console.WriteLine("El precio del artículo no puede ser negativo.");
        }
        else
        {
            int cambio = cantidadDinero - precioArticulo;

            Console.WriteLine("Cambio a devolver: $" + cambio);

            foreach (int moneda in monedas)
            {
                int cantidadDeMonedas = cambio / moneda;
                cambio %= moneda;

                if (cantidadDeMonedas > 0)
                {
                    Console.WriteLine($"Monedas de {moneda} centavos: {cantidadDeMonedas}");
                }
            }
        }

        Console.ReadLine(); // Espera a que el usuario presione Enter para salir.
    }
}
