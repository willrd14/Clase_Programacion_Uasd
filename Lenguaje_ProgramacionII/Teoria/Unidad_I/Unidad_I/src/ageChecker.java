import java.util.Scanner;

public class ageChecker{
    Scanner sc = new Scanner(System.in);
    int age;
    char holdLicence;

    public void mostrarAG(){
        System.out.println("Please enter your age: ");
        age = sc.nextInt();
        System.out.println("Do you hold a current driving licence? ");
        holdLicence = sc.next().charAt(0);

        if(age > 20){
            System.out.println("You are an adult");
        }
        else{
            System.out.println("You are an child");
        }

        if((age > 20) && (holdLicence == 'y')){
            System.out.println("You are your driving licence!");
        }
        else{
            System.out.println("You are not your driving licence!");
        }

        sc.close();
    }
}