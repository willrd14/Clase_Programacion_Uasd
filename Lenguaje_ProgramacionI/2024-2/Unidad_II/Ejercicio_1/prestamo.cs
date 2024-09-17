class Prestamo
{
    private Cliente cliente;
    private decimal capital;
    private decimal tasa;
    private int tiempo;

    public Prestamo(Cliente cliente, decimal capital, decimal tasa, int tiempo)
    {
        this.cliente = cliente;
        SetCapital(capital);
        SetTasa(tasa);
        SetTiempo(tiempo);
    }

    private void SetCapital(decimal capital)
    {
        if (capital <= 0)
            throw new ArgumentException("El capital debe ser mayor que cero.");
        this.capital = capital;
    }

    private void SetTasa(decimal tasa)
    {
        if (tasa < 1 || tasa > 100)
            throw new ArgumentException("La tasa debe estar entre 1% y 100%.");
        this.tasa = tasa;
    }

    private void SetTiempo(int tiempo)
    {
        if (tiempo <= 0)
            throw new ArgumentException("El tiempo debe ser mayor que cero.");
        this.tiempo = tiempo;
    }

    public decimal CalcularInteresSimple()
    {
        return capital * (tasa / 100) * tiempo;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Cliente ID: {cliente.Id}");
        Console.WriteLine($"Nombre: {cliente.Nombre}");
        Console.WriteLine($"Capital: ${capital}");
        Console.WriteLine($"Tasa: {tasa}%");
        Console.WriteLine($"Tiempo: {tiempo} años");
        Console.WriteLine($"Interés Simple: ${CalcularInteresSimple()}");
    }

    ~Prestamo()
    {
        Console.WriteLine("Destructor de Préstamo llamado.");
    }
}