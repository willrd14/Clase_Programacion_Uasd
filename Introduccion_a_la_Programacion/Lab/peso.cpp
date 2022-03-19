#include <iostream>
#include <string>

using namespace std;

struct TMB
{
    float mujer;
    float hombre;
    float nivelActFis;
};

struct Datos
{
    string nombre;
    int edad;
    char sexo[15];
    float peso;
    float estatura;
    char nivelActFis[5];
};

int main()
{
    TMB tmb;
    Datos dato;

    cout << "Digite su nombre: ";
    getline( cin, dato.nombre);

    cout << "Digite su edad: ";
    cin >> dato.edad;

    cout << "Digite su sexo [masculino] o [femenino]: ";
    cin >> dato.sexo;

    cout << "Digite su estatura: ";
    cin >> dato.estatura;

    cout << "Digite su peso: ";
    cin >> dato.peso;

    cout << "Nivel de actividad fisica Nula[N] Leve[L] Moderada[M] Regula[R] Extrema[E]: ";
    cin >> dato.nivelActFis;

    if (dato.sexo == femenino)
    {
        tmb.mujer = (10 * dato.peso) + (6.25 * dato.estatura) - (5 * dato.edad) - 161;
        cout << tmb.mujer << endl;
    }

    else
    {
        tmb.hombre = (10 * dato.peso) + (6.25 * dato.estatura) - (5 * dato.edad) + 5;
        cout << tmb.hombre << endl;
    }

    

    return 0;
}