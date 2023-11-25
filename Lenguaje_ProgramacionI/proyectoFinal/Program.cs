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

        switch (option){

            case 1:
            bibliotecario();
            break;

            case 2:
            usuario();
            break;

            caso 3:
            Console.WriteLine("Hasta luego!!");
            break;

            default:
            Console.WriteLine("Opcion no valida, intentelo de nuevo.");
            break;

        }
    }

    class Bibliotecario : Sistema {

        public string admin = "Admin";
        public int adminClave = 1234;

        public void  bibliotecario(){
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

    class Usuario : Sistema, Articulo {
        
        public string nombre;
        public string apellido;
        public string direccion;
        public int telefono;
        public string usuario;
        public int clave;
        public int obtion;

        string libro = @"C:\Users\willi\Code\Clase_Programacion_Uasd\Lenguaje_ProgramacionI\proyectoFinal\Libros.txt";
        string contenido = File.ReadAllText(libro);

        public override usuario(){
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

        public void pedir(){
            Console.WriteLine("Que articulo deseas pedir: ")
            Console.WriteLine("1. Libro");
            Console.WriteLine("2. VideoJuego");
            Console.WriteLine("3. Consola");
            Console.WriteLine("4. Pelicula");
            Console.WriteLine("5. Salir");
            int opcion = int.Parse(Console.ReadLine());

            switch(opcion){

                case 1:
                Console.WriteLine("Desea ver cuales libros tenemos disponibles?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                int opcionaLibro = int.Parse(Console.ReadLine());
                switch(opcionaLibro){
                    case 1:
                    Console.WriteLine(contenido);
                    Console.WriteLine("5. Salir");
                    int opcion2 = int.Parse(Console.ReadLine());
                    break;

                    case 2:
                    Console.WriteLine("Volviendo al menu.....");
                    pedir();
                    break;
                    
                }

                case 2:
                Console.WriteLine("Desea ver cuales videojuegos tenemos disponibles?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                int opcionesVideojuego = int.Parse(Console.ReadLine());
                break;

                case 3:
                Console.WriteLine("Desea ver cuales consolas tenemos disponibles?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                int opcionesConsola = int.Parse(Console.ReadLine());
                break;

                case 4:
                Console.WriteLine("Desea ver cuales peliculas tenemos disponibles?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                int opcionesPelicula = int.Parse(Console.ReadLine());
                break;

                case 5:
                Console.WriteLine("Desea ver cuales peliculas tenemos disponibles");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                int opcionesPeliculas = int.Parse(Console.ReadLine());
                break;

                default:
                Console.WriteLine("Opcion no valida");
                break;

            }
        }
    }

    class Articulo : Usuario, Bibliotecario{
        
        public bool articulos_disponibles;
        public string registrar;
        public string agregar;
        public int actualizar;
        public bool vencido;
    }
}