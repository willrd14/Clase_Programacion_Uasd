#include <iostream>
#include <vector>

using namespace std;

struct ventaBebida
{
    string nombreBebida;
    double precioBebida;
    int cantidadEnMaquina;
};

int main()
{
    ventaBebida venta;

    cout << "-----------------------------------------------------" << endl;
    cout << "Nombre de la Bebida |  Costo  |  Cantidad en Maquina " << endl;
    cout << "-----------------------------------------------------" << endl;
    cout << "Botella de Agua        20.00              20" << endl;
    cout << "Coca Cola              25.00              20" << endl;
    cout << "Seven Up               25.00              20" << endl;
    cout << "Montain Dew            30.00              20" << endl;
    cout << "Jugo V8                50.00              20" << endl;

    


    return 0;
}
