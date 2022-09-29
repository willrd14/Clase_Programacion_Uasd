using System;

class Rectangle {
	private int width;
	private int height;
	
	public Rectangle() {
		
		//rectangulo 1
		width = 25;
		height = 10;
		
		//rectangulo 2
		width = 20;
		height = 7;
		
	}
	
	public void setWidth(int w) {
		if (width >= 1 && width <= 30)
		{
			width = w;
		}
		else
		{
			Console.WriteLine("Valor invalido");
		}
	}
	public int getWidth() {return width;}
	
	public void setHeight(int h) {
		if (height >= 1 && height <= 30)
		{
			height = h;
		}
		else
		{
			Console.WriteLine("Valor invalido");
		}
	}
	public int getHeight() {return height;}
	
	public double getArea() {
		return width * height;
	}
	
	public void draw() {
		//dibujar un rectangulo con 
		int i, j;
		for (i = 1; i <= 10; i++) {
			for (j = 1; j <= 25; j++) {
				Console.Write("*", j);
			}
			Console.WriteLine("  ");
		}
		Console.ReadKey();
	}
	
	public void draw2() {
		//dibujar un rectangulo con 
		int i, j;
		for (i = 1; i <= 7; i++) {
			for (j = 1; j <= 20; j++) {
				Console.Write("*", j);
			}
			Console.WriteLine("  ");
		}
	}
}