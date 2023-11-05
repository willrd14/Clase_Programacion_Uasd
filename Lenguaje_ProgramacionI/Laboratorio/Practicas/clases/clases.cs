using System;
using System.Collections.Generic;
namespace myProyecto{

    public abstract class VehiculoBase{
        //atributos
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public Color Color {get; set;}

        //contructor de la clase
        public VehiculoBase(string marca, string modelo, Color color){
                Marca = marca;
                Modelo = modelo;
                Color = color;
        }
        

        //metodos setter o getter
        public virtual void MostrarInfo(){
            Console.WriteLine($"Mi Vehiculo Marca: {Marca}, Modelo: {Modelo}, de Color: {Color}");
        }

    }//fin vehiculoBase

    public abstract class vehiculoTerrestre : VehiculoBase, IArrancable {
        //atributos
        public int Ruedas {get; set;}
        //contructor de la clase
        public vehiculoTerrestre(string marca, string modelo, Color color, int ruedas)
        :base(marca,modelo,color)
        {
            Ruedas = ruedas;
        }
        //metodos setter o getter
        public override void MostrarInfo(){
            base.MostrarInfo();
            Console.WriteLine($"Tengo {Ruedas} ruedas. ");
        }

        public void Arrancar(){
            Console.WriteLine("El vehiculo Arranco");
        }
    }

}