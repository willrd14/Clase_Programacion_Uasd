namespace myProyecto1{
    
    public class Cliente{
        public string Nombre{get; set;}
        public List <VehiculoBase> Vehiculos {get;}
        //contructor
        public Cliente(string nombre = "cliente"){
            Nombre = nombre;
            Vehiculos = new List<VehiculoBase>();
        }

        public void AgregarVehiculo(VehiculoBase vehiculo){
            Vehiculos.Add(vehiculo);
        }

    }
}