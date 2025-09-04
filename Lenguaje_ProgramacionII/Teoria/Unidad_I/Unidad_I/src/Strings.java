public class Strings{
    String str1 = "Hello";
    String str2 = "Williams";
    String str3 = "You are " + str2;

    public void mostrarS(){
        System.out.println("Welcome: " + str3);
        System.out.println("Length: " + str1.length());
        System.out.println("Sub: " + str3.substring(0,5));
        System.out.println("Sub: " + str2.toUpperCase());
        System.out.println(str1.compareTo(str2));
        System.out.println(str1.equals(str2));
    }
}