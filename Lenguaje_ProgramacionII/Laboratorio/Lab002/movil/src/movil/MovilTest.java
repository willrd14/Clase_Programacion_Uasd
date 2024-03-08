package movil;

public class MovilTest{
	public void testMovil() {
		Libre movil1 = new Libre(10,2);
		movil1.calcularVelocidadFinal();
		assertEquals("Movimiento : Libre/nEspacio: 10.0/nTiempo: 2.0/nDistancia: 10.0/nVelocidad: 5.0/nAceleracion: 0.0", movil1.toString());
		
		Retardo movil2 = new Retardo(10, 2, 3);
		movil2.calcularVelocidadFinal();
		assertEquals("Movimiento : Libre/nEspacio: 10.0/nTiempo: 2.0/nDistancia: 7.0/nVelocidad: 2.857142857142857/nAceleracion: 3.0", movil2.toString());
	}

	private void assertEquals(String string, String string2) {
		// TODO Auto-generated method stub
		
	}
}
