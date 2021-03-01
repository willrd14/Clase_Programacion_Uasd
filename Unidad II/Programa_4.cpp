#include <iostream>

using namespace std;

int main(){
	int numero, factorial = 1;
	
	cout << "Ingresa el numero deseado: ";
	cin >> numero;
	
	for (int i = 1; i <= numero; i++){
		factorial = factorial * i;
	}
	
	cout << "\nEl Facotial del numero elegido es: " << factorial << endl;
	
	system("pause");
	return 0;

}
