import java.util.Scanner;

public class calculadora {
    public static void main(String[] args) {
        int num1 = 0;
        int num2 = 0;

        Scanner sc = new Scanner(System.in);
        System.out.println("Elija la operacion que desea realizar: ");
        System.out.println("1. Sumar");
        System.out.println("2. Restar");
        System.out.println("3. Multiplicar");
        System.out.println("4. Dividir");
        String op = sc.nextLine();

        System.out.println("Ingresa numero 1: ");
        num1 = sc.nextInt();
        System.out.println("Ingresa numero 2: ");
        num2 = sc.nextInt();

        switch (op) {
            case "1":
                int sum = num1 + num2;
                System.out.println("Resultado: " + sum);
                break;
            case "2":
                int rest = num1 - num2;
                System.out.println("Resultado: " + rest);
                break;
            case "3":
                int mult = num1 * num2;
                System.out.println("Resultado: " + mult);
                break;
             case "4":
                 int div = num1 / num2;
                 System.out.println("Resultado: " + div);
                 break;

        }
    }
}