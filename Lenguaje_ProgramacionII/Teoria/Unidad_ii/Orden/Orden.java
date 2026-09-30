package Unidad_ii.Orden;

public class Orden {
    public long ValorOrden = 0;
    public int itemCantidad = 10000000;
    public int itemprecio = 555500;

    public void CalcularTotal() {
        this.ValorOrden = (long) itemCantidad * itemprecio;
        System.out.println("El valor total del pedido es: " + ValorOrden);
    }
}
