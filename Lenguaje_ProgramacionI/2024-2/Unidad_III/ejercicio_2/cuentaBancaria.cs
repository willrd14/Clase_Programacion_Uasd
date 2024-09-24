public class CuentaBancaria
{
    private int numeroCuenta;
    private decimal saldo;
    private Titular titular;

    public CuentaBancaria(int numeroCuenta, decimal saldo, Titular titular)
    {
        this.numeroCuenta = numeroCuenta;
        this.saldo = saldo;
        this.titular = titular;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Número de Cuenta: {numeroCuenta}");
        Console.WriteLine($"Saldo: {saldo}");
        Console.WriteLine($"Titular: {titular}");
    }
}
