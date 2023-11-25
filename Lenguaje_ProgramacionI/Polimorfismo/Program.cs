using System;
class Polimorfismo{
    public static void Main() {
		
        IInfoDisplayable  geografia;
		
        geo= new circulo(); 
        geo.areaFiguras();   

        Geo = new triangulo(); 
        Geo.areaFiguras();  

	Geo = new rectangulo(); 
        Geo.areaFiguras();  
    }
}
