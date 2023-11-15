//Suma dos valores introducidos por teclado 


using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace sumaNS
{
	public class sumaCL
	{
		static void Main(string [] x)
		{
			int numero1, numero2,resultado;
			
			Console.WriteLine("Digite el primer valor ");
			numero1= Int32.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite el segundo valor");
			numero2= Int32.Parse(Console.ReadLine());
			
			resultado=numero1+numero2;
			
			Console.Clear(); 
			
			
			Console.WriteLine ("    RESULTADOS DE LA SUMA \n");
			Console.WriteLine("-----------------------------\n");
			Console.WriteLine("R:=> " + resultado);	
		}	
	}
}