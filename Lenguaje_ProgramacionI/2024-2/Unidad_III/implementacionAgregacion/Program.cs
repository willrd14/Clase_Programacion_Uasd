public class Motor
{
    public int Cilindros { get; set; }
    public int Potencia { get; set; }
}

public class Coche
{
    public Motor Motor { get; set; }
    // Otros atributos del coche
}

// Crear un motor
Motor miMotor = new Motor { Cilindros = 4, Potencia = 150 };

// Crear un coche
Coche miCoche = new Coche { Motor = miMotor };