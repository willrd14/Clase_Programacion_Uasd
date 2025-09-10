import java.util.Scanner;

public class valueChecker{
    Scanner sc = new Scanner(System.in);
    int value = 0;

    public void mostrarVG(){
        do {
            System.out.println("Enter a number: ");
            value = sc.nextInt();

            if (value == 7){
                System.out.println("That's lucky!");
            }
            else if(value == 13){
                System.out.println("That's unlucky!");
            }
            else if(value != 0){
                System.out.println("That number is neither lucky nor unlucky!");
            }
        }while(value != 0);

        sc.close();
    }
}