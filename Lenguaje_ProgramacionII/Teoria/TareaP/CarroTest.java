package TareaP;

public class CarroTest {

    public static void main(String[] args) {

        System.out.println("Información del primer carro:");
        Carro carro = new Carro();
        carro.mostrarInformacion();

        System.out.println("\nInformación del segundo carro:");
        Carro carro2 = new Carro("Honda", "Civic", 2022, 'B', 25000.00);
        carro2.mostrarInformacion();

        System.out.println("\nDespués de calcular la antigüedad:");
        carro.calcularAntiguedad();
        carro.mostrarInformacion();
        carro2.calcularAntiguedad();
        carro2.mostrarInformacion();
    }
    
}
