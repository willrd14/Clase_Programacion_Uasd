package movil;

public abstract class movil1 {
	protected double espacio;
	protected double tiempo;
	protected double distancia;
	protected double velocidad;
	protected double aceleracion;
	
	public movil1(double espacio2, double tiempo2) {
		// TODO Auto-generated constructor stub
	}

	public void movil(double espacio2, double tiempo2) {
		// TODO Auto-generated constructor stub
	}

	public void Movil(double espacio, double tiempo){
		this.espacio = espacio;
		this.tiempo = tiempo;
	}
	
	public abstract void calcularVelocidadFinal();

	public String toString() {
		return "Movimiento: " + this.getClass().getSimpleName() +"/nEspacio: " + espacio + "/nTiempo: " + tiempo + "/nDistancia: " + distancia + "/nVelocidad: " + velocidad + "/nAceleracion: " + aceleracion;
	}
}