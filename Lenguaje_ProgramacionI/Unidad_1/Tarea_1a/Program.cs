namespace Ejercicio1a{
    public class Program {
         static void Main(string []args) {
             Persona myPersona = new Persona();
             Console.Clear();
             Console.WriteLine("Digite el Nombre :");
             myPersona.nombre=Console.ReadLine();
             Console.WriteLine("Digite la Edad :");
             myPersona.edad=int.Parse(Console.ReadLine());
             myPersona.display();
        }

        
   }
}