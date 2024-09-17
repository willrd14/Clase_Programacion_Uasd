class Cliente
{
    private static int contadorId = 0;
    public int Id { get; private set; }
    public string Nombre { get; private set; }

    public Cliente(string nombre)
    {
        Id = ++contadorId;
        SetNombre(nombre);
    }

    private void SetNombre(string nombre)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre no puede ser nulo o estar vacío.");
        Nombre = nombre.Trim();
    }
}