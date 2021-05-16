#include <iostream>
using namespace std;

int main()
{
	string empleado1;
	string empleado2;
	float salario1;
	float salario2;
	int diferencia = salario1 / salario2;

	
	cout << "Ingrese su nombre: \n";
	cin >> empleado1;
	
	cout << "Ingrese su salario:\n";
	cin >> salario1;
	
	cout << "Ingrese su nombre:\n";
	cin >> empleado2;
	
	cout << "Ingrese su salario:\n";
	cin >> salario2;
	
	if (salario1 > salario2)
	{
		cout << "La persona con mas salario es: " << empleado1 << "\nEl cual devenga un salario de: " << salario1 << "\nLe gana " << diferencia << " pesos mas que " << empleado2;
	}
	
	else
	{
		cout << "La persona con mas salario es: " << empleado2 << "\nEl cual devenga un salario de: " << salario2 << "\nLe gana " << diferencia << " pesos mas que " << empleado1;
	}
}
