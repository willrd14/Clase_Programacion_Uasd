class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el capital del préstamo: ");
            decimal capital = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese la tasa de interés (1-100): ");
            decimal tasa = decimal.Parse(Console.ReadLine());

            Console.Write("Ingrese el tiempo en años: ");
            int tiempo = int.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nombre);
            Prestamo prestamo = new Prestamo(cliente, capital, tasa, tiempo);

            Console.WriteLine("\nInformación del Préstamo:");
            prestamo.MostrarInformacion();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}