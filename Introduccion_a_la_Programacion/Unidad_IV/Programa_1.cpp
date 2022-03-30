#include <iostream>
#include <string>
#include <vector>
#include <iomanip>

using namespace std;

struct StBebida {
	string nombre;
	double precio;
	int    cantidad;
};

int main()
{
  const int SALIR = 9;
  int    opcion;
  double montoIntroducido;
  double montoVentaTotal(0);

	vector<StBebida> bebida;
  bebida.push_back({"Botella de Agua",20.00, 20});
  bebida.push_back({"Coca Cola",      25.00, 20});
  bebida.push_back({"Seven Up",       25.00, 20});
  bebida.push_back({"Montain Dew",    30.00, 20});
  bebida.push_back({"Jugo V8",        50.00, 20});

  while( true )
  {
        //- Mostrando las bebidas disponibles
        cout << "Bebidas Disponibles" << '\n'
             << "-------------------" << '\n';
        for( int ind = 0; ind < bebida.size(); ++ind )
           cout << ind  + 1 << ".)"
                << setw(20) << bebida.at(ind).nombre   << '\t'
                << bebida.at(ind).precio   << '\t'
                << bebida.at(ind).cantidad << '\t'
                << endl;

        do {
            cout << "Introducir Num. Opcion (9-Terminar) : ";
            cin  >> opcion;
        } while ( ( opcion < 1 || opcion > 5 ) && opcion != SALIR );

        if ( opcion == SALIR ) break;

        if ( bebida.at(opcion - 1).cantidad < 1 )
        {
             cout << "\n\n"
                  << "Vevida Agotada !!!!!"
                  << "\n\n"
                  << endl;
             continue;
        }

        do {
            cout << "Introducir Monto (Mayor o igual que $" << bebida.at(opcion - 1).precio << ") : ";
            cin  >> montoIntroducido;
        } while ( montoIntroducido < bebida.at(opcion - 1).precio );

        double cambio = montoIntroducido - bebida.at(opcion - 1).precio;
        --bebida.at(opcion - 1).cantidad;

        cout << "\n\nCambio : " << cambio << endl;
  }

  montoVentaTotal = 0;

  for( int ind = 0; ind < bebida.size(); ++ind ) {
      montoVentaTotal += bebida.at(ind).precio * ( 20 - bebida.at(ind).cantidad );
  }

  cout << "Venta Total : " << montoVentaTotal << endl;

  return 0;
}
