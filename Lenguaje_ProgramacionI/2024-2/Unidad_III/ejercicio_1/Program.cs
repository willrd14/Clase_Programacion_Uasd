class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Console.WriteLine("Ingrese el tamaño del almacén:");
        int size = int.Parse(Console.ReadLine());
        Almacen almacen = new Almacen(size);

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Obtener Producto");
            Console.WriteLine("3. Buscar Producto");
            Console.WriteLine("4. Eliminar Producto");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Ingrese código del producto: ");
                    string codigo = Console.ReadLine();
                    Console.Write("Ingrese nombre del producto: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese precio del producto: ");
                    decimal precio = decimal.Parse(Console.ReadLine());
                    Producto producto = new Producto(codigo, nombre, precio);
                    almacen.AgregarProducto(producto);
                    break;
                case 2:
                    Console.Write("Ingrese el índice del producto: ");
                    int index = int.Parse(Console.ReadLine());
                    Producto prod = almacen.ObtenerProducto(index);
                    Console.WriteLine(prod != null ? prod.ToString() : "Producto no encontrado");
                    break;
                case 3:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string searchName = Console.ReadLine();
                    List<Producto> productosEncontrados = almacen.BuscarProducto(searchName);
                    foreach (var p in productosEncontrados)
                    {
                        Console.WriteLine(p.ToString());
                    }
                    break;
                case 4:
                    Console.Write("Ingrese el índice del producto a eliminar: ");
                    int deleteIndex = int.Parse(Console.ReadLine());
                    almacen.EliminarProducto(deleteIndex);
                    Console.WriteLine("Producto eliminado");
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}
