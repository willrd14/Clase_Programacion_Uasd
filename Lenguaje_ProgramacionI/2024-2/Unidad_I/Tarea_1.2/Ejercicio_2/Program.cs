using System;

namespace BasicOOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Introduce tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            Person person = new Person(nombre, edad);

            Console.WriteLine("Hola " + person.nombre + ", tienes " + person.edad + " años.");

            Console.ReadKey();
        }
        
    }

    class Person
    {
        public string nombre;
        public int edad;

        public Person(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}