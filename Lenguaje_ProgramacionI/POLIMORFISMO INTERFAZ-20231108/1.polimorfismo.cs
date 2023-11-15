/*INF-512 / UASD / OCTUBRE 2022 / By El Profe LoLo
  Polimorfismo.cs
  TEMA: Polimorfismo - Overloading o sobrecarga de metodo, polimorfismo estatico
  
  Descripción del ejemplo: 
   En la clase empleadoCL hay tres versiones de un mismo metodo. 
   Los tres con el mismo nombre (InformacionEmpleado()), pero cada uno tiene 
   cantidad y tipo de parametros distintos.  
   Luego en la clase prueba el metodo InformacionEmpleado() es llamado 
   y se le pasa un argumento al metodo. La version que se ejecutara sera 
   aquella cuyos parametros coincidan con los argumentos pasados, la cantidad
   y tipo de argumento debe ser igual a la cantidad y tipo de parametros del metodo*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolimorfismoNS
{
	
	//DEFINICION DE LA CLASE 
class empleadoCL {
	
	// Version No.1 del metodo llamado InformacionEmpleado()
      public void  InformacionEmpleado(string Texto1)  
	  {
           Console.WriteLine("\n" + Texto1);
      }
	  
	// Version No.2 del metodo llamado InformacionEmpleado()
     public void InformacionEmpleado(string Texto2,  int id) 
	 {
          Console.WriteLine( "\n" +  Texto2  +  " "  + id );
     }

    // Version No.3 del metodo llamado InformacionEmpleado()
     public double InformacionEmpleado(double sueldo) 
    {
		 Console.WriteLine("\nSalario devengado: " +  sueldo );
         return (sueldo);
   }
   
 }
    
	//CLASE DE PRUEBA, DONDE SE HARA LA LLAMADA AL METODO

public class PruebaCL  {

      public static void Main() {

    
	//Creacion de una instancia de la clase o variable de referencia llamada VarRefClaseEmpleado          
		    empleadoCL VarRefClaseEmpleado = new empleadoCL();
			
    
	//Llamada al metodo InformacionEmpleado() pasando los argumentos necesarios. 
	
	        //Este argumento coincide con los parametros de la version No. 1 del metodo
            VarRefClaseEmpleado.InformacionEmpleado("El Empleado"); 
            
			//El siguiente argumento coincide con los parametros de la version No.2
			VarRefClaseEmpleado.InformacionEmpleado( "Trabaja todos los dias.  Su Id es: " , 1002020 );
            
			//Este último argumento coincide con los parametros de la version No.3
			VarRefClaseEmpleado.InformacionEmpleado(35000 );
     }
  }
}
