public Libro(string registro, string agregar, int actualizar, bool vencido, string autor, int anioPublicacion)
    : base(registro, agregar, actualizar, vencido)
{
    Autor = autor;
    AnioPublicacion = anioPublicacion;
}

public override void Pendiente(string pendienteCompra)
{
    // Codigo para obtener libros pendientes de compra
}

public override void NuevoArticulo(string nuevoArticulo)
{
    // Codigo para agregar un nuevo libro
}

public override void ActualizarArticulo(string actualizarArticulo)
{
    // Codigo para actualizar un libro existente
}

public Revista(string registro, string agregar, int actualizar, bool vencido, string edicion, string frecuencia)
    : base(registro, agregar, actualizar, vencido)
{
    Edicion = edicion;
    Frequencia = frecuencia;
}

public override void Pendiente(string pendienteCompra)
{
    // Codigo para obtener revistas pendientes de compra
}

public override void NuevoArticulo(string nuevoArticulo)
{
    // Codigo para agregar una nueva revista
}

public override void ActualizarArticulo(string actualizarArticulo)
{
    // Codigo para actualizar una revista existente
}

