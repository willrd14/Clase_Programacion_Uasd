using System;
using System.Collections.Generic;

public void SetVence(short vencimiento)
{
    Vencido = vencimiento == 1;
}

public bool GetVence()
{
    return Vencido;
}

public void Pendiente(string pendienteCompra)
{
    // Codigo para obtener articulos pendientes de compra
}

public void NuevoArticulo(string nuevoArticulo)
{
    // Codigo para agregar un nuevo articulo
}

public void ActualizarArticulo(string actualizarArticulo)
{
    // Codigo para actualizar un articulo existente
}

public override void Pendiente(string pendienteCompra)
{
    // Codigo para obtener articulos pendientes de compra de miembros
}

public override void NuevoArticulo(string nuevoArticulo)
{
    // Codigo para agregar un nuevo articulo para miembros
}

public override void ActualizarArticulo(string actualizarArticulo)
{
    // Codigo para actualizar un articulo existente para miembros
}