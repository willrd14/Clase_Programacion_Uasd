#include <iostream>

using namespace std;

void cambia(int &);

int main()
{
	int numero = 5;
	cambia(numero);
	cout << "En main() = "
		 << numero << endl;
	return 0;
}

void cambia(int &valor)
{
	valor += 8;
	cout << "En cambia() = "
		 << valor << endl;
}
