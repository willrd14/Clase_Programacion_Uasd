#include <iostream>
#include <clocale> //para agragar caracteres en español como por ejemplo la "Ñ"//
using namespace std;
int main()
{
	setlocale(LC_CTYPE,"Spanish");
	
  char persona[50];
  double totalDevengado;
  double impuestos;

  double retencionMensual;

cout << "-----Este programa le permira calcular el monto de impuesto a pagar de acuerdo al total devengado durante un año---"<<endl<<endl<<endl;
cout <<"Introduzca su nombre:";
  cin.getline(persona,40,'\n');

cout << "Ingrese el monto devengado durante el año: "<<endl;;

  cin >> totalDevengado;std::cout <<endl;
  cin.ignore();

if (totalDevengado <= 416220.00)
{cout <<  "Hola "<< persona <<", su devengado anual es de :\n$";
cout << totalDevengado<< " pesos."<<endl<<"\nEl monto que debe pagar de impuesto sobre la renta es :"<<endl;
 cout <<"Exento (Libre de impuestos)" ;}

  else if (totalDevengado >= 416220.01 & totalDevengado <= 624329.00)
  {impuestos = (totalDevengado - 416220.01) * 0.15;
  retencionMensual = impuestos / 12;
  cout <<  "Hola "<< persona <<", su monto devengado anual es de :\n$";
  cout << totalDevengado<< " pesos."<<endl<<"\nEl monto que debe pagar de impuesto sobre la renta es :\n$";
  cout << impuestos << " pesos"<<endl;
  cout << "Valor mensual a retener: $"<<retencionMensual<< " pesos"<<endl;
  }

    else if (totalDevengado >= 624329.01 & totalDevengado <= 867123.00)
    {impuestos = ((totalDevengado - 624329.01) * 0.20) + 31216.00;
    retencionMensual = impuestos / 12;
    cout <<  "Hola "<< persona <<", su monto devengado anual es de :\n$";
    cout << totalDevengado<< " pesos."<<endl<<"\nEl monto que debe pagar de impuesto sobre la renta es :\n$";
    cout << impuestos << " pesos"<<endl;
    cout << "Valor mensual a retener: $"<<retencionMensual<< " pesos"<<endl;
    }

      else if (totalDevengado >= 867123.01)
      {impuestos = ((totalDevengado - 867123.01)*0.25) + 79776.00;
      retencionMensual = impuestos / 12;
      cout <<  "Hola "<< persona <<", su devengado anual es de :\n$";
      cout << totalDevengado<< " pesos."<<endl<<"\nEl monto que debe pagar de impuesto sobre la renta es :\n$";
      cout << impuestos << " pesos"<<endl;
      }

return 0;
}







