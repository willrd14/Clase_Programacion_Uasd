#include <iostream>

using namespace std;

int main()
{ 
	int n, suma = 0;
	
	cout << "Ingresa un numero: ";
	cin >> n;
	cout << "Los numeros primos son: ";
	
	for (int a = 1; a < n; a++)
	{
		int aux = 0;
		for (int div = 1; div <= a; div++)
		{
			if(a%div == 0 && a%1 == 0 )
			aux++;
			if (aux == 2)
			{
				cout << a << endl;
				suma = suma + a;
			}
		}
	}
	
	cout << "La suma de los numeros es: " << suma << endl;
	
	system("pause");
	return 0;
}
