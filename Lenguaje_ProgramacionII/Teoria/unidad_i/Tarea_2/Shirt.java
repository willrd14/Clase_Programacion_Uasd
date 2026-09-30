package unidad_i.Tarea_2;

public class Shirt {
    public int shirtID = 5;
    public String description = "?-description required-?";
    public char colorCode = 'R';
    public double price = 259.99;
    public int quantityInStock = 0;

    public void displayShirtInfo() {
        System.out.println("Shirt ID: " + shirtID);
        System.out.println("Description: " + description);
        System.out.println("Color Code: " + colorCode);
        System.out.println("Price: $" + price);
        System.out.println("Quantity in Stock: " + quantityInStock);
    }
}
