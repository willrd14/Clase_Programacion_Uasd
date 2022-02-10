#include <iostream>

using namespace std;

int main()
{
	int option;
	int num1;
	int num2;
	int resultado;
	
	cout << "Bienvindo a la calculadora basica\n";
	cout << "Que operacion desea realizar?\n";
	cout << "1 - suma\n";
	cout << "2 - resta\n";
	cout << "3 - multiplicacion\n";
	cout << "4 - diivision\n";
	cin >> option;
	
	cout << "Digite Valor deseado\n";
	cin >> num1;
	cout << "Digite Valor deseado\n";
	cin >> num2;
	
	if (option == 1)
	{
		resultado = num1 + num2;
		
		cout << resultado;
	}
	
	if (option == 2)
	{
		resultado = num1 - num2;
		
		cout << resultado;
	}
	
	if (option == 3)
	{
		resultado = num1 * num2;
		
		cout << resultado;
	}
	
	if (option == 4)
	{
		resultado = num1 / num2;
		
		cout << resultado; 
	}
	
	return 0;
}
