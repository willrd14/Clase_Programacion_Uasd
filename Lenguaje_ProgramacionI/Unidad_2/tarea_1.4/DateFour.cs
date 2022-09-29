using System;

public class DateFour {
	private int day;
	private int month;
	private int year;
	
	public DateFour() 
	{
		day = 1;
		month = 1;
		year = 2011;
	}
	
	public void setDate(int d, int m, int y){
		this.day = d;
		this.month = m;
		this.year = y;
	}
	public int getDay() {
		return day;
	}
	public int getMonth() {
		return month;
	}
	public int getYear() {
		return year;
	}
	public void displayDate() {
		
		Console.WriteLine("El dia -> " +day);
		Console.WriteLine("El mes -> " +month);
		Console.WriteLine("EL año -> " +year);
		
		Console.WriteLine("La fecha es: " + day + " / " + month + " / " + year);
		Console.ReadLine();
		return;
	}
}