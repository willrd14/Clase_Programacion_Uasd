import animalshop.animalTest;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int op;
        primitiveData pd = new primitiveData();
        Strings st = new Strings();
        imputVariables iv = new imputVariables();
        ageChecker ag = new ageChecker();
        valueChecker vc = new valueChecker();
        uniqueNums u = new uniqueNums();
        animalTest at = new animalTest();

        System.out.println("Que desea ver? ");
        System.out.println("1. Primitive Data");
        System.out.println("2. String");
        System.out.println("3. ImputVariables");
        System.out.println("4. AgeChecker");
        System.out.println("5. ValueChecker");
        System.out.println("6. UniqueNums");
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
                break;
            case 4:
                ag.mostrarAG();
                break;
            case 5:
                vc.mostrarVG();
                break;
            case 6:
                u.mostrarUN();
                break;

            }

        sc.close();
        }
}