namespace formas{

    public static void DisplayInformation(IInfoDisplayable obj)
    {
        obj.DisplayInfo();
    }
    public class Circulo : geometria, IInfoDisplayable
    {
        public void areaFiguras (){
            Console.WriteLine ("\nCALCULAR AREA DEL CIRCULO");
            Console.WriteLine ("\nPrimer valor Pi=3.14\n");
            Console.WriteLine ("Segundo valor Radio\n");
            obtenerDatos();	 
            resultado = valor1 * (valor2*valor2);
            Console.WriteLine ("\nAREA DE UN CIRCULO\n");
            Console.WriteLine("Resultado: " + resultado );  
            }
    }


    public class Triangulo : geometria, IInfoDisplayable
    {
        public void areaFiguras (){
            Console.WriteLine ("\nCALCULAR AREA DEL TRIANGULO");
            Console.WriteLine ("\nPrimer valor BASE\n");
            Console.WriteLine ("Segundo valor ALTURA\n");
            obtenerDatos();

            resultado = (valor1 * valor2)/2;
            Console.WriteLine ("\nAREA DE UN TRIANGULO\n");
            Console.WriteLine("Resultado: " + resultado ); 
        }
    }

    public class Rectangulo : geometria, IInfoDisplayable
    {
        public void areaFiguras (){
            Console.WriteLine ("\nCALCULAR AREA DEL RETANGULO");
            Console.WriteLine ("\nPrimer valor LARGO\n");
            Console.WriteLine ("Segundo valor ANCHO\n");
            obtenerDatos(); 
            resultado = (valor1 * valor2)/2;
            Console.WriteLine ("\nAREA DE UN RETANGULO\n");
            Console.WriteLine("Resultado: " + resultado ); 
        }
    }
}
