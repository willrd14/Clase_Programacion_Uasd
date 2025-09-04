import java.util.Scanner;

public class imputVariables{
    Scanner sc = new Scanner(System.in);
    public boolean boolVal;
    public byte byteVal;
    public char charVal;
    public short shortVal;
    public int intVal;
    public long longVal;
    public float floatVal;
    public double doubleVal;

    public void mostrarIV(){
        System.out.println("Please enter a boolean value: ");
        boolVal = sc.nextBoolean();
        System.out.println("Please enter a byte value: ");
        byteVal = sc.nextByte();
        System.out.println("Please enter a char value: ");
        charVal = sc.next().charAt(0);
        System.out.println("Please enter a short value: ");
        shortVal = sc.nextShort();
        System.out.println("Please enter an int value: ");
        intVal = sc.nextInt();
        System.out.println("Please enter a long value: ");
        longVal = sc.nextLong();
        System.out.println("Please enter a float value: ");
        floatVal = sc.nextFloat();
        System.out.println("Please enter a double value: ");
        doubleVal = sc.nextDouble();
        sc.close();
        System.out.println("boolean value: " + boolVal);
        System.out.println("byte value : " + byteVal);
        System.out.println("char value : " + charVal);
        System.out.println("short value : " + shortVal);
        System.out.println("int value : " + intVal);
        System.out.println("long value : " + longVal);
        System.out.println("double value : " + floatVal);
        System.out.println("double value : " + doubleVal);
    }
}