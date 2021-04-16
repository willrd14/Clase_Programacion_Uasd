#include <iostream>

using namespace std;

void printMessage();

int main()
{
	for (int i = 0; i < 10; i++)
	{
		printMessage();
	}
	return 0;
}

void printMessage()
{
	static int cantidadDeLlamada;
	cantidadDeLlamada++;
	cout << "Cantidad de veces que me han llamado: "
		 << cantidadDeLlamada << endl;
}

