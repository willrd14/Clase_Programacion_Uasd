namespace myProyecto{
    
public class Bicicleta : vehiculoTerrestre{
        public int NumeroMarchas {get; set;}
        
        public Bicicleta (string marca, string modelo, Color color, int numero_marchas)
        :base(marca,modelo,color,2)
        {
            NumeroMarchas = numero_marchas;
        }

        public Boolean TieneMarcha(Boolean marcha){
            return marcha;
        }

        public override void MostrarInfo(){
            base.MostrarInfo();
            
            Console.WriteLine($"Tengo {NumeroMarchas} Marchas. ");
        }
    }
}