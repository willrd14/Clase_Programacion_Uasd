using System;
namespace Ejercicio1a{
   public class Persona {
      public string nombre;
      public int edad;
      public void display() {
            Console.WriteLine("Mi nombre es {0}",  nombre);
             /* Agregar código para mostrar el valor de las 
             variable edad */
             Console.WriteLine("Mi edad es de {0}", edad);
      }
   }
}