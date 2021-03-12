#include <iostream>
using namespace std;
int main(int argc, char *argv[])
{
	int numDesde = 0, numHasta = 0, contador = 0;
	float suma = 0;
	cin >> numDesde >> numHasta;

	while (numDesde > numHasta)
	{
		cin >> numDesde >> numHasta;
	}

	for (int i = numDesde; i <= numHasta; i++)
	{
		if ((i % 9) == 0)
		{
			suma += i;
			contador++;
		}
	}
	cout << suma / contador;

	return 0;
}
