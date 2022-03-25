#include <iostream>
#include <vector>

using namespace std;

struct ventaBebida
{
    string nombreBebida;
    double precioBebida;
    int cantidadEnMaquina;
    float botellaAgua = 20.00;
    float cocaCola = 25.00;
    float sevenUp = 25.00;
    float montainDew = 30.00;
    float jugoV8 = 50.00;
};

int main()
{
    ventaBebida venta;

    while (1)
    {
        cout << "--------------------| Bienvenido |-------------------" << endl;
        cout << "-----------------------------------------------------" << endl;
        cout << "Nombre de la Bebida |  Costo  |  Cantidad en Maquina " << endl;
        cout << "-----------------------------------------------------" << endl;
        cout << "1-Botella de Agua      20.00              20" << endl;
        cout << "2-Coca Cola            25.00              20" << endl;
        cout << "3-Seven Up             25.00              20" << endl;
        cout << "4-Montain Dew          30.00              20" << endl;
        cout << "5-Jugo V8              50.00              20" << endl;
        cout << "0-Salir" << endl;

        cout << "Que bebida va a decear: ";
        getline (cin, venta.nombreBebida);

        cout << "Cuantas va a decear: ";
        cin >> venta.cantidadEnMaquina;
    }
    
    




    return 0;
}
