public class Almacen
{
    private Producto[] productos;

    public Almacen(int size)
    {
        productos = new Producto[size];
    }

    public void AgregarProducto(Producto producto)
    {
        for (int i = 0; i < productos.Length; i++)
        {
            if (productos[i] == null)
            {
                productos[i] = producto;
                return;
            }
        }
    }

    public Producto ObtenerProducto(int index)
    {
        if (index >= 0 && index < productos.Length)
        {
            return productos[index];
        }
        return null;
    }

    public List<Producto> BuscarProducto(string nombre)
    {
        List<Producto> encontrados = new List<Producto>();
        foreach (var producto in productos)
        {
            if (producto != null && producto.GetNombre().Contains(nombre))
            {
                encontrados.Add(producto);
            }
        }
        return encontrados;
    }

    public void EliminarProducto(int index)
    {
        if (index >= 0 && index < productos.Length)
        {
            productos[index] = null;
        }
    }
}
