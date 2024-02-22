import java.time.LocalDate;
import java.util.Scanner;

public class Menu {
    public static void main(String[] args) {
        int opcion;
        Scanner scanner = new Scanner(System.in);
        do {
            System.out.println("1. Crear paciente");
            System.out.println("2. Salir");
            System.out.print("Ingrese una opción: ");
            opcion = scanner.nextInt();
            switch (opcion) {
                case 1:
                    crearPaciente();
                    break;
                case 2:
                    System.out.println("Saliendo...");
                    break;
                default:
                    System.out.println("Opción no válida");
            }
        } while (opcion != 2);
    }

    private static void crearPaciente() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Ingrese el nombre: ");
        String name = scanner.next();
        System.out.print("Ingrese el apellido: ");
        String lname = scanner.next();
        System.out.print("Ingrese la fecha de nacimiento (dd/MM/yyyy): ");
        LocalDate fechaNac = LocalDate.parse(scanner.next());
        System.out.print("Ingrese el peso (kg): ");
        double pesoKg = scanner.nextDouble();
        System.out.print("Ingrese la altura (metros): ");
        double alto = scanner.nextDouble();
        Paciente paciente = new Paciente(name, lname, fechaNac, pesoKg, alto);
        System.out.println("Paciente creado: " + paciente);
    }
}

class Paciente {
    private String name;
    private String lname;
    private LocalDate fechaNac;
    private double pesoKg;
    private double alto;

    public Paciente(String name, String lname, LocalDate fechaNac, double pesoKg, double alto) {
        this.name = name;
        this.lname = lname;
        this.fechaNac = fechaNac;
        this.pesoKg = pesoKg;
        this.alto = alto;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getLname() {
        return lname;
    }

    public void setLname(String lname) {
        this.lname = lname;
    }

    public LocalDate getFechaNac() {
        return fechaNac;
    }

    public void setFechaNac(LocalDate fechaNac) {
        this.fechaNac = fechaNac;
    }

    public double getPesoKg() {
        return pesoKg;
    }

    public void setPesoKg(double pesoKg) {
        this.pesoKg = pesoKg;
    }

    public double getAlto() {
        return alto;
    }

    public void setAlto(double alto) {
        this.alto = alto;
    }

    public double getIMC() {
        return pesoKg / (alto * alto);
    }

    public String getAnalisisIMC() {
        double imc = getIMC();
        if (imc < 18.5) {
            return "Bajo peso";
        } else if (imc < 25) {
            return "Peso normal";
        } else if (imc < 30) {
            return "Sobrepeso";
        } else {
            return "Obesidad";
        }
    }

    @Override
    public String toString() {
        return "Paciente{" +
                "name='" + name + '\'' +
                ", lname='" + lname + '\'' +
                ", fechaNac=" + fechaNac +
                ", pesoKg=" + pesoKg +
                ", alto=" + alto +
                ", IMC=" + getIMC() +
                ", AnalisisIMC='" + getAnalisisIMC() + '\'' +
                '}';
    }
}