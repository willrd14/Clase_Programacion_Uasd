import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int op;
        primitiveData pd = new primitiveData();
        Strings st = new Strings();
        imputVariables iv = new imputVariables();

        System.out.println("Que desea ver? ");
        System.out.println("1. Primitive Data");
        System.out.println("2. String");
        System.out.println("3. ImputVariables");
        System.out.println("4. AgeChecker");
        op = sc.nextInt();

        switch (op) {
            case 1:
                pd.mostrarPD();
                break;
            case 2:
                st.mostrarS();
                break;
            case 3:
                iv.mostrarIV();
            }

        sc.close();
        }
}