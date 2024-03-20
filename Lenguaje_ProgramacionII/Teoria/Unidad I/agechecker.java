package agechecker;
import java.util.Scanner;

public class AgeChecker {
    public static void main(String[] args) { 
        Scanner in = new Scanner(System.in);
        int edad;
       
        System.out.print("ingresa tu edad: "); edad = in.nextInt();
        
        if(edad > 20)
            System.out.println("Tu eres menor de edad.");
        else
            System.out.println("Tu eres un adulto."); 
        in.close();
    }
}