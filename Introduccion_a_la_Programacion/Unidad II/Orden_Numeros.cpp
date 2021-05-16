#include <iostream>

using namespace std;

int main()
{
	int valor1;
	int valor2;
	int valor3;
	
	cout << "Ingrese valor deseado\n";
	cin >> valor1;
	cout << "Ingrese valor deseado\n";
	cin >> valor2;
	cout << "Ingrese valor deseado\n";
	cin >> valor3;
	
	if (valor1 > valor2 and valor1 > valor3)
	{
		cout << valor1 << "," << valor2 << "," << valor3;
	}
		if (valor2 > valor1 and valor2 > valor3)
		{
			cout << valor2 << "," << valor3 << "," << valor1;
		}
			if (valor3 > valor1 and valor3 > valor2)
			{
				cout << valor3 << "," << valor1 << "," << valor2;
			}
				if (valor1 == valor2 and valor1 == valor2)
				{
					cout << "Brother los valores son iguales, prueba en la siguiente vuelta XD";
				}
	return 0;
}
