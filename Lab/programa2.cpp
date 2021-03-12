#include <iostream>

using namespace std;

int main()
{
    int num;

   	cout <<  " Introduzca un numero entero: \n";
	cin  >> num;

    if ( num % 3 == 0 )
        cout << "\n   ES MULTIPLO DE 3 \n" << endl;
    else
        cout << "\n   NO ES MULTIPLO DE 3 \n" << endl;

	system("pause");
    return 0;
}
