/*INF-512 / UASD / OCTUBRE 2023 / By El Profe LoLo
  PolimorInterfazFG.cs
  TEMA: Polimorfismo - polimorfismo dinamico atravez de interfaz
  
  Descripción del ejemplo: 
  En el programa se define una interfaz llamada Ifiguras que 
  contiene el metodo llamado areaFiguras(). A continuacion se 
  define la clase padre Geometria y las clases hijo circulo, triangulo, rectangulo
  estas implementan la interfaz y heredan de la clase geometria
  Finalmente en la clase PrincipalCL se define un objeto o variable de 
  referencia llamada Geo asociada a la interface Ifiguras
  con la cual se vincula las clases  que implementan 
  la interface. 

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolimorfismoInterfazNS
{

//DECLARAMOS LA INTERFAZ LLAMADA Ifiguras 

  interface    Ifiguras 
  {
        void areaFiguras();    //Metodo sin cuerpo de la interface Ifiguras
		
  }
  
  //Clase Base o padre
  public class Geometria
  {
public double valor1, valor2, resultado;	 //Campos de la clase

public void CapturaDatos(){                  //Metodo de la clase

	Console.WriteLine ("\n Primer valor");
	valor1= double.Parse(Console.ReadLine());
	
	Console.WriteLine ("\n Segundo valor");
	valor2= double.Parse(Console.ReadLine());	  
	  
}
  }

//IMPLEMENTACION DE LA INTERFAZ

class CIRCULO  :  Geometria,Ifiguras
{
		
         public void areaFiguras() 
		 {
			 Console.WriteLine ("\nCALCULAR AREA DEL CIRCULO");
			 Console.WriteLine ("\nPrimer valor Pi=3.14\n");
			 Console.WriteLine ("Segundo valor Radio\n");
			 CapturaDatos();
				 
         resultado = valor1 * (valor2*valor2);
		 Console.WriteLine ("\nAREA DE UN CIRCULO\n");
		 Console.WriteLine("Resultado: " + resultado );  
         }
}
	

//IMPLEMENTACION DE LA INTERFAZ

class TRIANGULO  :  Geometria,Ifiguras
{
		
      public void areaFiguras() 
	{
			  Console.WriteLine ("\nCALCULAR AREA DEL TRIANGULO");
			Console.WriteLine ("\nPrimer valor BASE\n");
			Console.WriteLine ("Segundo valor ALTURA\n");
			CapturaDatos();
				 
         resultado = (valor1 * valor2)/2;
		 Console.WriteLine ("\nAREA DE UN TRIANGULO\n");
		 Console.WriteLine("Resultado: " + resultado );  
        }
}



//IMPLEMENTACION DE LA INTERFAZ

class RETANGULO :  Geometria,Ifiguras
{
		
         public void areaFiguras() 
		 {
			  Console.WriteLine ("\nCALCULAR AREA DEL RETANGULO");
			 Console.WriteLine ("\nPrimer valor LARGO\n");
			 Console.WriteLine ("Segundo valor ANCHO\n");
			 CapturaDatos();
				 
         resultado = (valor1 * valor2)/2;
		 Console.WriteLine ("\nAREA DE UN RETANGULO\n");
		 Console.WriteLine("Resultado: " + resultado );  
         }
}



class PrincipalCL {
	
     public static void Main() {
		 
		//Definicion de la variable de referencia asociada a la interfaz

 Ifiguras Geo;
		  Geo= new CIRCULO(); 
          Geo.areaFiguras();   
		  
          Geo = new TRIANGULO(); 
          Geo.areaFiguras();  
		  
		  Geo = new RETANGULO(); 
          Geo.areaFiguras();  

   }
}
}