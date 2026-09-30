package TareaP;

public class Carro {
    String marca = "Toyota";
    String modelo = "supra";
    int año = 2020 ;
    char color = 'R';
    double precio = 200000;
    int antiguedad = 0;

    public Carro() {
        
    }

    public Carro(String marca, String modelo, int año, char color, double precio) {
        this.marca = marca;
        this.modelo = modelo;
        this.año = año;
        this.color = color;
        this.precio = precio;
    }

    public void calcularAntiguedad() {
        this.antiguedad = java.time.Year.now().getValue() - this.año;
    }

    public void mostrarInformacion() {
        System.out.println("Marca: " + marca);
        System.out.println("Modelo: " + modelo);
        System.out.println("Año: " + año);
        System.out.println("Color: " + color);
        System.out.println("Precio: $" + precio);
        System.out.println("Antigüedad: " + antiguedad + " años");
    }

    @Override 
    public String toString() {
        return "Carro{" +
                "marca='" + marca + '\'' +
                ", modelo='" + modelo + '\'' +
                ", año=" + año +
                ", color=" + color +
                ", precio=" + precio +
                ", antiguedad=" + antiguedad +
                '}';
    }

}
