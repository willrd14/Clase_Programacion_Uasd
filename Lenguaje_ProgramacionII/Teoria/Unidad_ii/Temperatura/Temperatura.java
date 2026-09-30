package Unidad_ii.Temperatura;

public class Temperatura {
    public double temperaturaFahrenheit = 150.32;

    public void calcularCelsius() {
        double celsius = (this.temperaturaFahrenheit - 32) * 5 / 9;
        System.out.println("La temperatura de " + temperaturaFahrenheit + "°F es igual a " + celsius + "°C");
    }
}
