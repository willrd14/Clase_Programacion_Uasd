#include <iostream>

using namespace std;

struct TFactura{
	long factNumero;
	string factCliente;
	string factFecha;
	double factMonto;
	double factDescuento;
	double factNeto;
};

int main(){
	TFactura factura;
	
	cout << "Introducir los datos de la factura" << endl;
	
	cout << "Num Factura ";
	cin >> factura.factNumero;
	cin.ignore();
	
	cout << "Cliente ";
	getline( cin, factura.factCliente );
	
	cout << "Fecha ";
	getline( cin, factura.factFecha );
	
	cout << "Monto Facturado ";
	cin >> factura.factMonto;
	cin.ignore();
	
	if ( factura.factMonto >= 20000 && factura.factMonto < 30000 ) {
		factura.factDescuento = factura.factMonto * 0.07;
	} else if ( factura.factMonto >= 30000 && factura.factMonto < 50000 ) {
		factura.factDescuento = factura.factMonto * 0.1;
	} else if ( factura.factMonto >= 0000 ) {
		factura.factDescuento = factura.factMonto * 0.14;
	} else{
		factura.factDescuento = 0;
	}
	
	factura.factNeto = factura.factMonto - factura.factDescuento;
	
	cout << "------ Factura ------" << endl
		 << "Numero "     << factura.factNumero    << '\n'
		 << "Cliente "    << factura.factCliente   << '\n'
		 << "Fecha "      << factura.factFecha     << '\n'
		 << "Monto "   	  << factura.factMonto     << '\n'
		 << "Descuento "  << factura.factDescuento << '\n'
		 << "Monto neto " << factura.factNeto      << endl;
		 
	system ("pause");
	return 0;
}









