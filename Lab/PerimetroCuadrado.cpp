/*Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo (El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro)
Pueden crear por ejemplo un proyecto llamado PerimetroCuadrado.*/

#include <iostream>

using namespace std;

int main(){
	double ladoCuadrado;
	double resultado;
	
	cout << "------ Bienvenido a la calculadora de perimetro de un cubo -------" << endl;
	
	cout << "Ingrese el valor deseado: \n";
	cin >> ladoCuadrado;
	
	resultado = ladoCuadrado * 4;
	
	cout << "El perimetro del cuadrado es: \n"
		 << resultado << endl;
		 
	system("pause");
	return 0;
}
