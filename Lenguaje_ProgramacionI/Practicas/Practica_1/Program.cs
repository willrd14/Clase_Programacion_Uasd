//Calculadora Semi-Avanzada.

Console.WriteLine("Que operacion desea hacer?");
Console.WriteLine("1. Suma");
Console.WriteLine("2. Resta");
Console.WriteLine("3. Multiplicacion");
Console.WriteLine("4. Division");
Console.WriteLine("");
int op = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(""); 

if (op == 1)
{
    Console.WriteLine("Digite Valor deseado: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite Valor deseado: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int suma = num1 + num2;
    Console.WriteLine("El resultado de la suma es: " + suma);
}

if (op == 2)
{
    Console.WriteLine("Digite Valor deseado: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite Valor deseado: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int resta = num1 - num2;
    Console.WriteLine("El resultado de la resta es: " + resta);
}

if (op == 3)
{
    Console.WriteLine("Digite Valor deseado: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite Valor deseado: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int mult = num1 * num2;
    Console.WriteLine("El resultado de la multiplicacion es: " + mult);
}

if (op == 4)
{
    Console.WriteLine("Digite Valor deseado: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite Valor deseado: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int div = num1 / num2;
    Console.WriteLine("El resultado de la divicion es: " + div);
}

if (op > 4)
{
    Console.WriteLine("Esa Opcion no esta disponible, intenta otra opcion.");
}