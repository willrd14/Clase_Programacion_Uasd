using System;
namespace Ejercio1{
	public class DateTwoTest {

		static void Main(string[] args) {
			DateTwo Obj1 = new DateTwo();
			
			int dia = Obj1.getDay();
			int mes = Obj1.getMonth();
			int year = Obj1.getYear();

			Console.WriteLine("Dia: " + dia);
			Console.WriteLine("Mes: " + mes);
			Console.WriteLine("Year: " + year);
		}// end Main
    
	} // end class

}//end Namespace