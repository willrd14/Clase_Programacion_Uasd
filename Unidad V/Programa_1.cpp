#include <iostream>

using namespace std;

int main()
{
	string user;
	int edad;
	
	cout << "***** Bienvenido ******"
		 << endl
		 << endl
		 << "Introduce tu nombre: " 
		 << endl;
	cin >> user;
	
	cout << "Introduce tu edad: " << endl;
	cin >> edad;
	
	if (edad > 18)
	{
		cout << "Bienvenido " << user << endl;	
	} else
	{
		cout << "Todavia no tienes la edad... Perdon" << endl;
	}
	
	system ("pause");
	return 0;
}
