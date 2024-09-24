public class Producto
{
    private string codigo;
    private string nombre;
    private decimal precio;

    public Producto(string codigo, string nombre, decimal precio)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.precio = precio;
    }

    public string GetCodigo()
    {
        return codigo;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public decimal GetPrecio()
    {
        return precio;
    }

    public override string ToString()
    {
        return $"Codigo: {GetCodigo()} Nombre: {GetNombre()} Precio: {GetPrecio()}";
    }
}
