using System;
namespace Ejercicio2{
	public class RectangleTest {
		public static void Main() {
			Rectangle r1 = new Rectangle();
			Console.WriteLine("Recatangulo por defecto creado");
			Console.WriteLine("ancho = 25, altura = 10");
			r1.draw();
			Rectangle r2 = new Rectangle();
			Console.WriteLine("Recatangulo por defecto creado");
			Console.WriteLine("ancho = 20, altura = 7");
			r2.draw2();
			Console.WriteLine("El area de un rectangulo es: {0} ", +r2.getArea());
			Console.ReadLine();
		}// end main
	} // end class
}