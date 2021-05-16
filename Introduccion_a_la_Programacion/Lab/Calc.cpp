//PROGRAMA MODULAR
#include <iostream>

using namespace std;

int opcion;

float A=1;

float B=1;

float resultado;

//PROTOTIPO
void Pedir(float A, float B); // No devuelve es void

float suma(float A, float B, float C);
float resta(float A, float B, float C);
float mult(float A, float B, float C);
float div(float A, float B, float C);

int main(){



cout << "Que operacion desea realizar Suma [1] Resta [2] Multiplicacion [3] Division [4]." << endl;



cin >> opcion;

// funcion ingresa


if (opcion==1){

suma(A,B); 
cout << C;

}

if (opcion==2){

    resta(A,B)   ; 
cout << C;

}

if (opcion==3){

   mult(A,B)   ; 
cout << C;

}

if (opcion==4){

   cout<< div(A,B)   ; 
cout << C;

}

//DESARROLLO O IMPLEMENTACIÓN DE FUNCIONES

void Pedir(float A, float B)
{
cout << "Ingrese un número: ";

cin >> A;

cout << "Ingrese otro numero: ";

cin >> B;

}

float suma(float A,float B)
{
float C = A+B;
return C;
}

float resta(float A, float B)
{
float C = A-B;
return C;
}
float mult(float A, float B)
{
float C = A*B;
return C;
}
float div(float A, float B)
{
float C = A/B;
return C;
}

