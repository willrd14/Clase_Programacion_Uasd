using System;
using System.IO;

namespace ProyectoFinal
{
    interface IUsuario
    {
        void Usuario();
        void Registrarse();
        void MenuUsuario();
        void Pedir();
        void Renovar();
    }

    interface IBibliotecario
    {
        void Bibliotecario();
        void MenuAdmin();
        void AgregarArticulos();
        void EliminarArticulos();
        void CobrarDemora();
        void ActualizarStock();
    }

    class Sistema
    {
        public int option;

        public void sistema()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("*Bienvenido a la Biblioteca Nacional*");
            Console.WriteLine("*************************************");
            Console.WriteLine("*           Usted es? :             *");
            Console.WriteLine("*   1. Administrador/Bibliotecario  *");
            Console.WriteLine("*   2. Usuario                      *");
            Console.WriteLine("*   3. Salir                        *");
            Console.WriteLine("*************************************");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Bibliotecario bibliotecario = new Bibliotecario();
                    bibliotecario.Bibliotecario();
                    break;

                case 2:
                    Usuario usuario = new Usuario();
                    usuario.Usuario();
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

    class Bibliotecario : IBibliotecario
    {
        public string admin = "Admin";
        public int adminClave = 1234;

        public void Bibliotecario()
        {
            Console.WriteLine("Digite su usuario: ");
            admin = Console.ReadLine();

            Console.WriteLine("Digite la clave: ");
            adminClave = int.Parse(Console.ReadLine());

            if (admin == "Admin" && adminClave == 1234)
            {
                Console.WriteLine("Bienvenido Administrador!!");
                MenuAdmin();
            }
            else
            {
                Console.WriteLine("Usuario y/o clave invalida");
            }
        }

        public void MenuAdmin()
        {
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
                    AgregarArticulos();
                    break;

                case 2:
                    EliminarArticulos();
                    break;

                case 3:
                    CobrarDemora();
                    break;

                case 4:
                    ActualizarStock();
                    break;

                case 5:
                    Console.WriteLine("Saliendo de sistema.......");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }

        public void AgregarArticulos()
        {
            Console.WriteLine("Pagina para agregar articulos");
            MenuAdmin();
        }

        public void EliminarArticulos()
        {
            Console.WriteLine("Pagina para eliminar articulos");
            MenuAdmin();
        }

        public void CobrarDemora()
        {
            Console.WriteLine("Pagina para cobrar demora");
            MenuAdmin();
        }

        public void ActualizarStock()
        {
            Console.WriteLine("Pagina para actualizar stock");
            MenuAdmin();
        }
    }

    class Usuario : IUsuario
    {
        public string nombre;
        public string apellido;
        public string direccion;
        public int telefono;
        public string usuario;
        public int clave;
        public int obtion;

        public void Usuario()
        {
            Console.WriteLine("Usted esta registrado? : ");
            Console.WriteLine("1. Si");
            Console.WriteLine("2. No");
            obtion = int.Parse(Console.ReadLine());

            switch (obtion)
            {
                case 1:
                    Console.WriteLine("Ingrese el Usuario: ");
                    usuario = Console.ReadLine();
                    Console.WriteLine("Ingrese la Clave: ");
                    clave = int.Parse(Console.ReadLine());

                    Console.WriteLine("Bienvenido de nuevo!!");
                    MenuUsuario();
                    break;

                case 2:
                    Registrarse();
                    break;
            }
        }

        public void Registrarse()
        {
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
            clave = int.Parse(Console.ReadLine());
            Console.WriteLine("Bienvenido!! y gracias por registrarse.");
            Usuario();
        }

        public void MenuUsuario()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("*          Menu Principal           *");
            Console.WriteLine("*************************************");
            Console.WriteLine("*    1. Renovacion de articulos     *");
            Console.WriteLine("*    2. Pedir Articulos             *");
            Console.WriteLine("*    3. Salir                       *");
            Console.WriteLine("*************************************");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Renovar();
                    break;

                case 2:
                    Pedir();
                    break;

                case 3:
                    Console.WriteLine("Bye!!!");
                    break;
            }
        }

        public void Pedir()
        {
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

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Desea ver cuales libros tenemos disponibles?");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    int opcionaLibro = int.Parse(Console.ReadLine());
                    switch (opcionaLibro)
                    {
                        case 1:
                            // Muestra los libros disponibles
                            Console.WriteLine("1. El Hobbit");
                            Console.WriteLine("2. El Señor de los Anillos");
                            Console.WriteLine("3. El Silmarillion");
                            Console.WriteLine("4. La Comunidad de la Risa");

                            Console.WriteLine("Elige un libro: ");
                            int opcion2 = int.Parse(Console.ReadLine());

                            if (opcion2 >= 1 && opcion2 <= 4)
                            {
                                Console.WriteLine($"Haz elegido el libro {opcion2}");
                            }
                            else
                            {
                                Console.WriteLine("Opción no válida");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Volviendo al menu.....");
                            Pedir();
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("Desea ver cuales videojuegos tenemos disponibles?");
                    Console.WriteLine("1. Si");
                    Console.WriteLine("2. No");
                    int opcionesVideojuego = int.Parse(Console.ReadLine());
                    switch (opcionesVideojuego)
                    {
                        case 1:
                            // Muestra los videojuegos disponibles
                            Console.WriteLine("1. Minecraft");
                            Console.WriteLine("2. Call of Duty");
                            Console.WriteLine("3. Fortnite");
                            Console.WriteLine("4. GTA V");

                            Console.WriteLine("Elige un videojuego: ");
                            int opcion3 = int.Parse(Console.ReadLine());

                            if (opcion3 >= 1 && opcion3 <= 4)
                            {
                                Console.WriteLine($"Haz elegido el videojuego {opcion3}");
                            }
                            else
                            {
                                Console.WriteLine("Opción no válida");
                            }
                            break;

                        case 2:
                            Console.WriteLine("Volviendo al menu.....");
                            Pedir();
                            break;
                    }
                    break;

                // Resto de casos...
            }
        }

        public void Renovar()
        {
            Console.Clear();
            Console.WriteLine("Por cuanto tiempo desea renovar: ");
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ha decidido renovar por {time} días, gracias por preferirnos.");
            Console.WriteLine("Desea volver al menu? : ");
            Console.WriteLine("1.Si");
            Console.WriteLine("2.No");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Volviendo al menu...");
                MenuUsuario();
            }
            else
            {
                Console.WriteLine("Gracias por preferirnos");
            }
        }
    }

    class Program
    {
        public static void Main()
        {
            Sistema sistema = new Sistema();
            sistema.sistema();
        }
    }
}

