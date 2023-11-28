using System;
using System.Collections.Generic;
using System.IO;

namespace ProyectoFinal{

    class Sistema{

        Console.Clear();
        public int option;

        public void sistema(){
            Console.WriteLine("*************************************");
            Console.WriteLine("*Bienvenido a la Biblioteca Nacional*");
            Console.WriteLine("*************************************");
            Console.WriteLine("*           Usted es? :             *");
            Console.WriteLine("*   1. Administrador/Bibliotecario  *");
            Console.WriteLine("*   2. Usuario                      *");
            Console.WriteLine("*   3. Salir                        *");
            Console.WriteLine("*************************************");
            option = int.Parse(Console.ReadLine());

            switch (option){

                case 1:
                bibliotecario();
                break;

                case 2:
                usuario();
                break;

                case 3:
                Console.WriteLine("Hasta luego!!");
                break;

                default:
                Console.WriteLine("Opcion no valida, intentelo de nuevo.");
                break;

            }
        }
        
    }

    class Bibliotecario : Sistema, Articulo {

        Console.Clear();

        public string admin = "Admin";
        public int adminClave = 1234;

        public void  bibliotecario(){
            Console.WriteLine("Digite su usuario: ");
            admin = Console.ReadLine();

            Console.WriteLine("Digite la clave: ");
            adminClave = int.Parse(Console.ReadLine());

            if(admin == "Admin" && adminClave == 1234){
                Console.WriteLine("Bienvenido Administrador!!");
                menuAdmin();
            } else{
                Console.WriteLine("Usuario y/o clave invalida");
            }
        }

        public void menuAdmin(){
            
            Console.WriteLine("********************************");
            Console.WriteLine("*      Menu Bibliotecario      *");
            Console.WriteLine("********************************");
            Console.WriteLine("*      1- Agregar articulo     *");
            Console.WriteLine("*      2- Eliminar articulo    *");
            Console.WriteLine("*      3- Cobrar demoras       *");
            Console.WriteLine("*      4- Actualizar Stock     *");
            Console.WriteLine("*      5- Salir                *");
            Console.WriteLine("********************************");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                agregaArticulos();
                break;

                case 2:
                eliminaArticulos();
                break;

                case 3:
                cobraDemora();
                break;

                case 4:
                actualizaStock();
                break;

                case 5:
                Console.WriteLine("Saliendo de sistema.......");
                break;

                default:
                Console.WriteLine("Opcion no valida");
                break;
            }
        }
    }

    class Usuario : Sistema{
        
        Console.Clear();
        public string nombre;
        public string apellido;
        public string direccion;
        public int telefono;
        public string usuario;
        public int clave;
        public int obtion;

        string libro = @"C:\Users\willi\Code\Clase_Programacion_Uasd\Lenguaje_ProgramacionI\proyectoFinal\Libros.txt";
        string contenido = File.ReadAllText(libro);
        string VideoJuego = @"C:\Users\willi\Code\Clase_Programacion_Uasd\Lenguaje_ProgramacionI\proyectoFinal\Videojuegos.txt";
        string contenido2 = File.ReadAllText(VideoJuego);
        string Consola = @"C:\Users\willi\Code\Clase_Programacion_Uasd\Lenguaje_ProgramacionI\proyectoFinal\Consola.txt";
        string contenido3 = File.ReadAllText(Consola);
        string Pelicula = @"C:\Users\willi\Code\Clase_Programacion_Uasd\Lenguaje_ProgramacionI\proyectoFinal\Pelicula.txt";
        string contenido4 = File.ReadAllText(Pelicula);

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
                menuUsuario();
                break;

                case 2:
                registrarse();
                break;
            }
        } 

        public virtual registrarse(){
            Console.Clear();
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
            usuario();
        }

        public void menuUsuario(){
            
            Console.Clear();
            public int opcion;

            Console.WriteLine("*************************************");
            Console.WriteLine("*          Menu Principal           *");
            Console.WriteLine("*************************************");
            Console.WriteLine("*    1. Renovacion de articulos     *");
            Console.WriteLine("*    2. Pedir Articulos             *");
            Console.WriteLine("*    3. Salir                       *");
            Console.WriteLine("*************************************");
            opcion = int.Parse(Console.ReadLine());

            switch(opcion){
                case 1:
                renovar();
                break;

                case 2:
                pedir();
                break;

                case 3:
                Console.WriteLine("Bye!!!");
                break;
            }

        }

        public void pedir(){
            
            Console.Clear();
            Console.WriteLine("********* Pedir Articulo **********");
            Console.WriteLine("*    Que articulo deseas pedir:   *");
            Console.WriteLine("*            1. Libro             *");
            Console.WriteLine("*            2. VideoJuego        *");
            Console.WriteLine("*            3. Consola           *");
            Console.WriteLine("*            4. Pelicula          *");
            Console.WriteLine("*            5. Salir             *");
            Console.WriteLine("***********************************");
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
                    
                    if(opcion2 == 1) {
                        Console.WriteLine("Haz elegido El Hobbit");
                    } elif(opcion2 == 2){
                        Console.WriteLine("Haz elegido El Señor de los Anillos");
                    } elif(opcion2 == 3){
                        Console.WriteLine("Haz elegido El Silmarillion");
                    } elif{
                        Console.WriteLine("La Comunidad de la Risa");
                    } else{
                        pedir();
                    }
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
                switch(opcionesVideojuego){
                    case 1:
                    Console.WriteLine(videojuegos);
                    Console.WriteLine("5. Salir");
                    int opcion3 = int.Parse(Console.ReadLine());
                    if(opcion3 == 1) {
                        Console.WriteLine("Haz elegido Minecraft");
                    } elif(opcion3 == 2){
                        Console.WriteLine("Haz elegido Call of Duty");
                    } elif(opcion3 == 3){
                        Console.WriteLine("Haz elegido Fortnite");
                    } elif(opcion3 == 4){
                        Console.WriteLine("Haz elegido GTA V");
                    } else{
                        pedir();
                    }

                    case 2:
                    Console.WriteLine("Volviendo al menu.....");
                    pedir();
                    break;
                }
                break;

                case 3:
                Console.WriteLine("Desea ver cuales consolas tenemos disponibles?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                int opcionesConsola = int.Parse(Console.ReadLine());
                switch(opcionesConsola){
                    case 1:
                    Console.WriteLine(consolas);
                    Console.WriteLine("5. Salir");
                    int opcion4 = int.Parse(Console.ReadLine());
                    if(opcion4 == 1) {
                        Console.WriteLine("Haz elegido PlayStation 5");
                    } elif(opcion4 == 2){
                        Console.WriteLine("Haz elegido Xbox Series X/S");
                    } elif(opcion4 == 3){
                        Console.WriteLine("Haz elegido Nintendo Switch");
                    } elif(opcion4 == 4){
                        Console.WriteLine("Haz elegido Steam Deck");
                    } else{
                        Console.WriteLine("Volviendo al menu..........");
                        pedir();
                    }
                    break;

                    case 2:
                    Console.WriteLine("Volviendo al menu.........");
                    pedir();
                    break;
                }
                break;

                case 4:
                Console.WriteLine("Desea ver cuales peliculas tenemos disponibles?");
                Console.WriteLine("1. Si");
                Console.WriteLine("2. No");
                int opcionesPelicula = int.Parse(Console.ReadLine());
                switch(opcionesPelicula){
                    case 1:
                    Console.WriteLine(peliculas);
                    Console.WriteLine("5. Salir");
                    int opcion5 = int.Parse(Console.ReadLine());
                    if(opcion5 == 1) {
                        Console.WriteLine("Haz elegido Spider Man:No Way Home");
                    } elif(opcion5 == 2){
                        Console.WriteLine("Haz elegido The Matrix Resurrections");
                    } elif(opcion5 == 3){
                        Console.WriteLine("Haz elegido El rey Leonardo");
                    } elif(opcion5 == 4){
                        Console.WriteLine("Haz elegido Joker");
                    }else{
                        Console.WriteLine("Volviendo al menu..........");
                        pedir();
                    }
                    break;

                    case 2:
                    Console.WriteLine("Volviendo al menu.........");
                    pedir();
                    break;

                }
                break;

                case 5:
                Console.WriteLine("Gracias por preferirnos");
                break;

                default:
                Console.WriteLine("Opcion no valida");
                break;

            }
        }

        public void renovar(){

            Console.Clear();
            Console.WriteLine("Por cuanto tiempo desea renovar: ");
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine("A desidido renovar por : ", time, " dias, gracias por preferirnos.");
            Console.WriteLine("Desea volver al menu? : ");
            Console.WriteLine("1.Si");
            Console.WriteLine("2.No");
            int option = int.Parse(Console.ReadLine());
            if (option == 1) {
                Console.WriteLine("Volviendo al menu...");
                menu();
            }else{
                Console.WriteLine("Gracias por preferirnos");
            }
        }

    }

    class Articulo : Bibliotecario{
        
        public string registrar;
        public string agregar;
        public int actualizar;
        public bool vencido;

        

        public void agregaArticulos(){
            Console.WriteLine("Pagina para agregar articulos");
            menuAdmin();
        }
        
        public void eliminaArticulos(){
            Console.WriteLine("Pagina para eliminar articulos");
            menuAdmin();
        }

        public void cobraDemora(){
            Console.WriteLine("Pagina para cobrar demora");
            menuAdmin();
        }

        public void actualizaStock(){
            Console.WriteLine("Pagina para actualizar stock");
            menuAdmin();
        }
    }

    class Program{
    
        public static void Main(){

            Sistema sistema = new sistema();
            sistema.sistema();
        }
    }
}