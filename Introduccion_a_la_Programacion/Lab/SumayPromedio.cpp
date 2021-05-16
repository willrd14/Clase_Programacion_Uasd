/* Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto. */

#include <iostream>

using namespace std;

int main(){
	int num1, num2, num3, num4, resSuma, resPromedio;
	
	cout << "Ingrese valores: \n";
	cin >> num1;
	
	cout << "Ingrese valores: \n";
	cin >> num2;
	
	cout << "Ingrese valores: \n";
	cin >> num3;
	
	cout << "Ingrese valores: \n";
	cin >> num4;
	
	resSuma = num1 + num2;
	resPromedio = num3 * num4;
	
	cout << "El resultado de la suma es: \n" << resSuma << endl;
	cout << "El resultado de el producto: "  << resPromedio << endl;

	return 0;
}
