class CuentaBancaria
{
    public string NombreTitular;
    public string NumeroCuenta;
    public double Saldo;

    public CuentaBancaria(string nombreTitular, string numeroCuenta, double saldo)
    {
        NombreTitular = nombreTitular;
        NumeroCuenta = numeroCuenta;
        Saldo = saldo;
    }

    public void Depositar(double cantidad)
    {
        Saldo += cantidad;
    }

    public void Retirar(double cantidad)
    {
        Saldo -= cantidad;
    }

    public void MostrarDetalles()
    {
        Console.WriteLine($"Nombre Titular: {NombreTitular}");
        Console.WriteLine($"Número de Cuenta: {NumeroCuenta}");
        Console.WriteLine($"Saldo: ${Saldo:F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        CuentaBancaria cuenta1 = new CuentaBancaria("Juan Perez", "1234567890", 1000.0);
        CuentaBancaria cuenta2 = new CuentaBancaria("Maria Ramirez", "1053367841", 1500.0);

        Console.WriteLine("Detalles de la Cuenta 1:");
        cuenta1.MostrarDetalles();
        Console.WriteLine();

        Console.WriteLine("Detalles de la Cuenta 2:");
        cuenta2.MostrarDetalles();
        Console.WriteLine();

        cuenta1.Depositar(2000);
        cuenta2.Retirar(500);

        Console.WriteLine("Detalles de la Cuenta 1 despues del deposito: ");
        cuenta1.MostrarDetalles();
        Console.WriteLine();

        Console.WriteLine("Detalles de la Cuenta 2 despues del retiro: ");
        cuenta2.MostrarDetalles();
        Console.WriteLine();

        Console.ReadLine();
    }
}