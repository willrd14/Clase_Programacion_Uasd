package Unidad_ii.Cliente;

public class Cliente {

    public int idCliente = 3880;
    public char estadoCliente = 'N';
    public double totalCompradoAnual = 0.0;

    public void MostrarClienteInfo() {
        System.out.println("ID del Cliente: " + idCliente);
        System.out.println("Estado del Cliente (N/V): " + estadoCliente);
        System.out.println("Total comprado al año: " + totalCompradoAnual);
    }
}