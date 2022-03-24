#include <iostream>

using namespace std;

int main()
{
	int num1;
	int num2;
	int suma;
	int resta;
	int mult;
	int div;
	int res;

	cout << "Digite Valor deseado: " << endl;
	cin >> num1;
	cout << "Digite Valor deseado: " << endl;
	cin >> num2;

	suma = num1 + num2;
	resta = num1 - num2;
	mult = num1 * num2;
	div = num1 / num2;
	res = num1 / num2;

	cout << "El resultado de las operaciones son: " << suma << endl << resta << endl << div << endl << res << endl;

	return 0;
}
