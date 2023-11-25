using System;
using System.Collections.Generic;
using System.IO;

namespace ProyectoFinal{

    class Sistema{

        public int option;

        Console.WriteLine("***********************************");
        Console.WriteLine("Bienvenido a la Biblioteca Nacional");
        Console.WriteLine("***********************************");
        Console.WriteLine("Usted es? : ");
        Console.WriteLine("1. Administrador/Bibliotecario");
        Console.WriteLine("2. Usuario");
        Console.WriteLine("3. Salir");
        option = int.Parse(Console.ReadLine());
    }

    class Bibliotecario : Sistema {

        public string admin = "Admin";
        public int adminClave = 1234;

        public override bibliotecario{
            Console.WriteLine("Digite su usuario: ");
            admin = Console.ReadLine();

            Console.WriteLine("Digite la clave: ");
            adminClave = int.Parse(Console.ReadLine());

            if(admin == "Admin" && adminClave == 1234){
                Console.WriteLine("Bienvenido Administrador!!")
            } else{
                Console.WriteLine("Usuario y/o clave invalida");
            }
        }
        
    }

    class Usuario : Sistema {
        
        public string nombre;
        public string apellido;
        public string direccion;
        public int telefono;
        public string usuario;
        public int clave;
        public int obtion;

        Console.WriteLine("Usted esta registrado? : ");
        Console.WriteLine("1. Si");
        Console.WriteLine("2. No");
        obtion = int.Parse(Console.ReadLine());

        switch (obtion){
            case 1:
            Console.WriteLine("Ingrese el Usuario: ");
            usuario = Console.ReadLine();
            Console.WriteLine("Ingrese la Clave: ");
            clave = int.Parse(Console.ReadLine());

            Console.WriteLine("Bienvenido de nuevo!!");
            break;

            case 2:
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su direccion: ");
            direccion = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono: ");
            telefono = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su usuario: ");
            usuario = Console.ReadLine();
            Console.WriteLine("Ingrese su clave: ");
            clave = Console.ReadLine();
            Console.WriteLine("Bienvenido!! y gracias por registrarse.");
            break;
        }
    }
}