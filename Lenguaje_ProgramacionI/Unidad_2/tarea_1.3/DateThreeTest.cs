using System;
namespace Ejercio1{
	public class DateThreeTest {

		public static void Main(string[] args) {
		DateThree dateobj = new DateThree();
		dateobj.setDay(20); 
		dateobj.setMonth(10); 
		dateobj.setYear(2003);

		Console.WriteLine("La fecha es: " + dateobj.getDay() + "/" + dateobj.getMonth() + "/" + dateobj.getYear()); 
		} // end main
	} // end class

}  //end namespace