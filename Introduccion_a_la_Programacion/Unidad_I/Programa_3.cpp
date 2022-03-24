#include <iostream>

using namespace std;

int main()
{
    char nombre[30];
    int edad;

    cout << "Cual es su nombre? " << endl;
    cin >> nombre;
    cout << "Cual es su edad? " <<  endl;
    cin >> edad;

    cout << "Hola " << nombre << " usted tiene " << edad << " años de edad." << endl;

    return 0;
}