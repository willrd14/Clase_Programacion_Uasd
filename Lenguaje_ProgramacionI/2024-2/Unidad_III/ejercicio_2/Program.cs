class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de Titular
        Titular titular = new Titular("Marco Jose Rosa", "H2311574", new DateTime(2002, 4, 30));

        // Crear una instancia de CuentaBancaria y asignarle el titular
        CuentaBancaria cuentaBancaria = new CuentaBancaria(2004, 5000.75m, titular);

        // Mostrar la información de la cuenta bancaria
        cuentaBancaria.MostrarInformacion();
    }
}
