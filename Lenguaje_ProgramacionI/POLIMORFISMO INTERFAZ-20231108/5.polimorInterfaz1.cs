/*INF-512 / UASD / JUNIO 2022 / By El Profe LoLo
  PolimorInterfaz1.cs
  TEMA: Polimorfismo - polimorfismo dinamico atravez de interface
  
  Descripción del ejemplo: 
  En el programa se define una interface llamada IuniUASD que 
  contiene el metodo llamado Carrera(). A continuacion se 
  definen tres clases: FacCienciasCL, EscInformaticaCL y 
  ProgramacionICL. Cada una de las clase implementa la interfaz. 
  Finalmente en la clase PruebaCL se define una variable de 
  referencia llamada varRefInterfaz asociada a la interfaz IuniUASD
  con la cual se vinculan cada una de las clases que implementan 
  la interfaz, usando una sola variable de referencia para todas. 

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolimorfismoInterfazNS
{

//DECLARAMOS LA INTERFACE LLAMADA IuniUASD

  interface    IuniUASD  
  {
        void Carreras();    //Metodo sin cuerpo de la interface IuniUASD
  }
  

//IMPLEMENTACION DE LA INTERFACE

class FacCienciasCL  :  IuniUASD  
{
         public void Carreras() 
		 {
         Console.WriteLine("\n FACULTAD DE CIENCIAS UASD\n");			 
         Console.WriteLine("Ofrece carreras en disciplinas diversas, incluyendo Informatica\n");
         }
}
		   
class EscInformaticaCL  :  IuniUASD  

{
         public void Carreras() 
		 {  
		 Console.WriteLine("ESCUELA DE INFORMATICA UASD\n");	
         Console.WriteLine("Ofrece varias carreras en el area de tecnologia\n");
         }
}
	

class  ProgramacionICL:  IuniUASD  

{
         public void Carreras() 
		 { 
         Console.WriteLine("CARRERA LICENCIATURA EN INFORMATICA\n");			 
         Console.WriteLine("Tiene varias asignaturas de programacion, incluye C++, C#, Java\n");
         }
}
	



class PruebaCL {
	
     public static void Main() {
		 
		
		 
//Mensaje generico, independiente de la interfaz y las clases 
Console.Clear();
Console.WriteLine("\n UNIVERSIDAD AUTONOMA DE SANTO DOMINGO\n");
Console.WriteLine("Dispone de carreras agrupadas por facultades\n");		  
         
		 
		 //Definicion de la variable de referencia asociada a la interfaz IuniUASD
         IuniUASD varRefInterfaz;
		 
		 
		 //Con una misma variable de referencia vinculamos cada clase que implementa la interfaz
		  //Luego se llama el metodo carreras() que sera accesado a traves de la variable de referencia. 
		  
		  varRefInterfaz = new FacCienciasCL(); 
          varRefInterfaz.Carreras();      
         
		  varRefInterfaz = new EscInformaticaCL();
          varRefInterfaz.Carreras();
         
     	 varRefInterfaz = new ProgramacionICL();
          varRefInterfaz.Carreras();         

   }
}
}