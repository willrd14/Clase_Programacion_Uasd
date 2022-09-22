public class Shirt{
    public int shirtID = 15; //Default ID for the shirt

    public String description = "-description required-";
    //default
    //The color codes are R=Red, G=Green, and B=Blue, U=Unset
    public char colorCode = 'U';
    public double price = 150.0; //Default price for all shirt
    public int quantityInStock = 0; //Default quantity for all shirt

    //This method display the values for an item
    public void displayShirtInformation(){
        Console.WriteLine("Shirt ID: " + shirtID);
        Console.WriteLine("Shirt description: " + description);
        Console.WriteLine("Color code: " + colorCode);
        Console.WriteLine("Shirt Price: " + price);
        Console.WriteLine("Quantity in Stock: " + quantityInStock);
    }
    // end of display method
    // end of class
}
