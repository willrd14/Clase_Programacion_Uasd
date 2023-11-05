namespace myProyecto {
    
    public class Automovil : vehiculoTerrestre{
        public int numeroPuertas {get; set;}
        public Boolean RadioFM {get; set;}
                
        public Automovil (string marca, string modelo, Color color, int Puertas, Boolean RadioFM)
        :base(marca,modelo,color,4)
        {
            numeroPuertas = Puertas;
            RadioFM = RadioFM;
        }

        public override void MostrarInfo(){
            base.MostrarInfo();
            /*if(RadioFM){
                Console.WriteLine($"Tengo {numero_puertas} Numero de puertas.");
                Console.WriteLine($"Tengo una Radio Integrado.");
            }else {
                Console.WriteLine($"Numero de puertas: {numero_puertas}");
            }*/
            Console.WriteLine($"Numero de puertas: {numeroPuertas}");
            
        }

        public void Arrancar(){
            Console.WriteLine("El vehiculo Arranco.");
        }
        
    }
}