import java.util.Scanner;

public class uniqueNums{
    int[] numbers = new int[5];
    Scanner sc = new Scanner(System.in);
    int num = 0, numValues = 0;
    boolean valid = true;

    public void  mostrarUN(){
        while(numValues < numbers.length){
            do {
                valid = true;
                System.out.print("Please enter a unique number: ");
                num = sc.nextInt();

                for(int i = 0; i < numbers.length; i++){
                    if(num == numbers[i]){
                        System.out.println("Number already exists");
                        valid = false;
                        break;
                    }
                }
            }while(!valid);
            numbers[numValues] = num;
            numValues++;
        }

        sc.close();

        for(int numV: numbers){
            System.out.println("Number value: " + numV);
        }
    }
}