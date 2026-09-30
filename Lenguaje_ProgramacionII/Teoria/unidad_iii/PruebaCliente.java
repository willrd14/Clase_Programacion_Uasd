package unidad_iii;

public class PruebaCliente {

  public static void main(String args[]) {

    // Tarea 1: declarar e inicializar dos instancias de Cliente
    Cliente objetoCliente1;
    Cliente objetoCliente2;

    objetoCliente1 = new Cliente();
    objetoCliente2 = new Cliente();

    // Asignar valores a las variables miembro del primer cliente
    objetoCliente1.clienteID = 1111;
    objetoCliente1.nombre = "Juan Perez";
    objetoCliente1.email = "juan.perez@example.com";

    // Asignar valores distintos al segundo cliente
    objetoCliente2.clienteID = 2222;
    objetoCliente2.nombre = "Maria Gomez";
    objetoCliente2.email = "maria.gomez@example.com";

    System.out.println("--- Tarea 1: dos objetos con valores distintos ---");
    objetoCliente1.muestraClienteInfo();
    objetoCliente2.muestraClienteInfo();

    // Tarea 2: asignar una referencia a otra
    // Ahora ambas variables apuntan al mismo objeto (el de Juan Perez);
    // el objeto de Maria Gomez queda sin referencias.
    objetoCliente2 = objetoCliente1;

    System.out.println("--- Tarea 2: despues de objetoCliente2 = objetoCliente1 ---");
    objetoCliente1.muestraClienteInfo();
    objetoCliente2.muestraClienteInfo();
  }
}
