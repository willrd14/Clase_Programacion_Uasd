#include <iostream>

using namespace std;

int main()
{
    double num1;
    double num2;
    double num3;
    double prom;

    cout << "Digita valores deseados: " << endl;
    cin >> num1;
    cout << "Digita valores deseados: " << endl;
    cin >> num2;
    cout << "Digite valores deseados: " << endl;
    cin >> num3;

    prom = num1 + num2 + num3 / 3;

    cout << "El resultado es: " << prom;

    return 0;
}