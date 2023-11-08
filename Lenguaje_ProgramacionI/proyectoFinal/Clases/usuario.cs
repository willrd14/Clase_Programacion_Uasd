using System;
using System.Collections.Generic;

namespace ProyectoFinal{

    public virtual string Registrar(string registro){
      Registro = registro;
      return "Usuario registrado";
  }

  public virtual bool Renovar(short renovacion){
      Renovar = renovacion == 1;
      return Renovar;
  }

  public virtual void Pedir(string pedir) {
      Pedir = pedir;
  }

  public virtual void Tiempo(int tiempoPrestamo){
      Tiempo = tiempoPrestamo;
  }
}