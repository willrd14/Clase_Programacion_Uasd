package Unidad_ii.Persona;

public class Persona {
    public int edadAnios = 24;
    public long edadDias;
    public long edadMinutos;
    public long edadSegundos;
    public long edadMilisegundos;

    public void calcularEdad() {
        this.edadDias = (long) edadAnios * 365;
        this.edadMinutos = this.edadDias * 24 * 60;
        this.edadSegundos = this.edadMinutos * 60;
        this.edadMilisegundos = this.edadSegundos * 1000;

        System.out.println("Usted tiene: " + edadAnios + " años de edad.");
        System.out.println("Usted tiene: " + edadDias + " días de edad.");
        System.out.println("Usted tiene: " + edadMinutos + " minutos de edad.");
        System.out.println("Usted tiene: " + edadSegundos + " segundos de edad.");
        System.out.println("Usted tiene: " + edadMilisegundos + " milisegundos de edad.");
    }
}
