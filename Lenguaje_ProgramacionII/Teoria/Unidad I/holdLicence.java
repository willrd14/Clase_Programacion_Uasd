import java.util.Scanner;

public class holdLicence {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int age;

        System.out.print("Please enter your age: ");
        age = in.nextInt();

        System.out.print("Do you hold a current driving licence? ");
        char holdLicence = in.next().charAt(0);

        if((age > 20) && (holdLicence == 'y'))
            System.out.println("You are an adult and can hire a car");
        else
            System.out.println("You are not an adult so  cannot hire a car");

        in.close();
    }
}