#include <iostream>

using namespace std;

void despliegaMensaje()
{
	cout << "Bienvenido a nuestra prueba\n";
}

int suma(int a, int b)
{
	return a + b;
}

int main()
{
	despliegaMensaje();
	cout << suma (4,15) << endl;
	return 0;
}
