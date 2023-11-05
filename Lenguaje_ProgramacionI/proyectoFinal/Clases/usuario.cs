using System;
using System.Collections.Generic;

namespace ProyectoFinal{

    public class Usuario{

        private string registro;
        private bool renovar;
        private string pedir;
        private int tiempo;

        public string bienvenida(){
            Console.WriteLine("******** Bienvenido/a ********");
            Console.WriteLine("Desea registrarse?");
            Console.WriteLine("1 - Si");
            Console.WriteLine("2 - No");
           string respuesta =  Console.ReadLine(Convert.ToInt32(respuesta));
        }


    }
}