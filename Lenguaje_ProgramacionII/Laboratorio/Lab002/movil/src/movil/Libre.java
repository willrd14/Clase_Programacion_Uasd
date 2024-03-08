package movil;

public class Libre extends movil1{
	public Libre(double espacio, double tiempo) {
		super(espacio, tiempo);
	}
	
	@Override
	public void calcularVelocidadFinal() {
		this.velocidad = this.espacio / this.tiempo;
		this.aceleracion = 0;
	}
}