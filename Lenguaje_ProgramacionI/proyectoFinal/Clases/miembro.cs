using System;
using System.Collections.Generic;

public Miembro(string registro, bool renovar, string pedir, int tiempoPrestamo, bool miembro)
    : base(registro, renovar, pedir, tiempoPrestamo)
{
    Miembro = miembro;
}

public override string Registrar(string registro)
{
    if (Miembro)
    {
        return base.Registrar(registro);
    }
    else
    {
        return "No es miembro";
    }
}