/* Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio. */

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
	resPromedio = num3 / num4;
	
	cout << "El resultado de la suma es: " << resSuma << endl
		 << "El resultado del promedio es: " << resPromedio << endl;
		 
	return 0;
}
