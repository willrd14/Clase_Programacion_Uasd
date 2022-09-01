class Calculadora{

    static void Main(string[] args)
    { 
        double num1=0;
        double num2=0;
        string entrada;
        char op='\u0000';
        double resultado=0;
        if (args.Length == 0){
                Console.Clear();
                Console.WriteLine("Digite Valor1: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite Valor2: ");
                num2 = Convert.ToInt32(Console.ReadLine());
            
                Console.WriteLine("Que operacion desea hacer?");
                Console.WriteLine("[ +, -, /, * ]");
                entrada=(Console.ReadLine());        
         } else if (args.Length == 3){
                num1 = Convert.ToDouble(args[0]);
                num2 = Convert.ToDouble(args[2]);
                string str1=args[1];
                op=str1[0];            
                   
         }
        
         resultado=Calculadora.Calcular(num1, num2,op);        
         Console.WriteLine(resultado);
     }

     static double Calcular(double a, double b, char op){

        double result = 0;
        switch(op){ 
            case '+': result =a+b;
             break;
             case '-': result =a-b;
             break;
             case '/': result =a/b;
             break;
             case '*': result =a*b;
             break;                          
        }


        return result;

     }   

}