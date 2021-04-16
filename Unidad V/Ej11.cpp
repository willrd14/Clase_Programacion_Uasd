#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

struct Triangulo
{
	//Miembro dato
	double base;
	double altura;
	//Miembro funcion
	double area();
};

void imprimeTriangulo(Triangulo);
Triangulo creaTriangulo(double, double);
Triangulo creaTriangulo();
