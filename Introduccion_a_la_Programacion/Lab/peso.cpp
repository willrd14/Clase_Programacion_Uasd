#include <iostream>
#include <string>

using namespace std;

struct TMB
{
    float mujer;
    float hombre;
};

struct Datos
{
    string nombre;
    int edad;
    char sexo[5];
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

    cout << "Digite su sexo [M] o [F]: ";
    cin >> dato.sexo;

    cout << "Digite su peso: ";
    cin >> dato.peso;

    cout << "Nivel de actividad fisica Nula[N] Leve[L] Moderada[M] Regula[R] Extrema[E]: ";
    cin >> dato.nivelActFis;

    






    return 0;
}