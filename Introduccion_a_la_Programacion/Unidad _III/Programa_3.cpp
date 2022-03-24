#include <iostream>
#include <string>

using namespace std;

struct Stfecha
{
	unsigned int aaaa;
	unsigned int mm;
	unsigned int dd;
};

struct Stfactura
{
	unsigned int numero;
	Stfecha  fecha;
	string nombreCliente;
	float ventaBruta;
	float montoImpuesto;
};

int main()
{
	Stfactura factura;

	cout << "Factura" << endl;

	cout << "Numero: ";
	cin >> factura.numero;

	cout << "Fecha\n"
	     << "AAAA: ";
	cin >> factura.fecha.aaaa;

	cout << "MM: ";
	cin >> factura.fecha.mm;

	cout << "DD: ";
	cin >> factura.fecha.dd;
	cin.ignore();

	cout << "Nombre de Cliente: ";
	getline(cin, factura.nombreCliente);

	cout << "Total Facturado: ";
	cin >> factura.ventaBruta;

	cout << "Total Impuesto: ";
	cin >> factura.montoImpuesto;

	cout << "\n\n\n"
	     << "Datos de la Factura" << endl
	     << "Numero: " << factura.numero << endl
	     << "Fecha: "  << factura.fecha.dd << "-"
	     		   << factura.fecha.mm << "-"
			   << factura.fecha.aaaa << endl
	     << "Cliente: "  << factura.nombreCliente << endl
	     << "Total Facturado: " << factura.ventaBruta << endl
	     << "Monto Impuesto(s): " << factura.montoImpuesto << endl
	     << "Valor Neto: " << (factura.ventaBruta + factura.montoImpuesto) << endl;

	return 0;
}
