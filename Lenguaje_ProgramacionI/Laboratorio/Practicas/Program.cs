using System;
using System.Collections.Generic;
namespace myProyecto{

    public partial class program{

    static void Main(string[] args){
        //Crear vehiculos
        Automovil automovil = new Automovil("Toyota","Camry",Color.Rojo,16,true);
        Automovil automovil2 = new Automovil("Nisan","R38",Color.Azul,32,false);
        Bicicleta miBici = new Bicicleta ("GT", "forse", Color.Verde,7);
        Cliente micliente = new Cliente("Mario");
        micliente.AgregarVehiculo(automovil);
        micliente.AgregarVehiculo(automovil2);
        micliente.AgregarVehiculo(miBici);
        //Mostrar informacion del cliente
        Console.WriteLine($"Vehiculos de {micliente.Nombre} : ");
        foreach (var vehiculo in micliente.Vehiculos){
            vehiculo.MostrarInfo();
            Console.WriteLine();
        }
        
    }
}
}