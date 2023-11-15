/*INF-512 / UASD / OCTUBRE 2022 / By El Profe LoLo
  Polimorfismo2.cs
  TEMA: Polimorfismo - Overloading o sobrecarga de metodo, polimorfismo estatico
  
  Descripción del ejemplo: 
  En la clase llamada aritmeticaCL hay dos metodos llamados operacion() 
  que tienen el mismo modificador, el mismo tipo de retorno, el mismo nombre,
  pero con parametros y cuerpos diferentes.

  En la clase prueba se invoca el metodo operacion() pasando un argumento. La versión 
  del metodo que se ejecutará será aquel cuyo tipo y cantidad de parametros coincida
  con el tipo y cantidad de argumentos pasados.
  CAPTURA DATOS DESDE EL METODO MAIN*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace polimorfismoNS
{

    public class aritmeticaCL
    {
       
	   public double valor1, valor2, solucion; // Observar que estan declarada como double
		
      //Primera version del metodo operacion 
	  public void operacion(double numero1, double numero2)
        {
            solucion = valor1 + valor2;
				Console.WriteLine("La suma de " + valor1 + " + " +
              valor2 + " = " + solucion);
        }
		
		//Segunda version del metodo operacion 
		   
        public void operacion(int primero, int segundo)
        {
            solucion = valor1 - valor2;
				Console.WriteLine("La resta de " + valor1 + " - " +
              valor2 + " = " + solucion);
		}
    }
   

    class Prueba
    {
        static void Main(string[] args)
        {
            //Declaracion de la variable referencia llamada VarRefClaseAritmetica
			aritmeticaCL VarRefClaseAritmetica = new aritmeticaCL();
         
	
			//Captura de valores a ser calculados. Observar que el tipo de datos capturado es double
			Console.WriteLine("\nDigite el primer numero: ");
            VarRefClaseAritmetica.valor1  =double.Parse(Console.ReadLine());
     
            Console.WriteLine("Digite el segundo numero: ");
             VarRefClaseAritmetica.valor2 = double.Parse(Console.ReadLine());
        
			//LLAMADA AL METODO operacion() NOTA:La version del metodo a ejecutarse será 
			                              //aquel cuyo tipo y cantidad de parametros coincida
                                          //con el tipo y cantidad de argumentos pasados
			
VarRefClaseAritmetica.operacion( VarRefClaseAritmetica.valor1,VarRefClaseAritmetica.valor2);
			
        }
    }
}