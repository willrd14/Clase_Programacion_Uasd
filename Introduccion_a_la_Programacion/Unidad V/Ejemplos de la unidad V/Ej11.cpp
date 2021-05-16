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

int main()
{
	Triangulo tri1 = creaTriangulo(2.5, 4.8);
	Triangulo tri2 = creaTriangulo();
	imprimeTriangulo(tri1);
	imprimeTriangulo(tri2);
	return 0;
}

double Triangulo::area()
{
	return base * altura / 2;
}

void imprimeTriangulo(Triangulo t)
{
	cout << "\nBase : " << t.base;
	cout << "\nBase : " << t.altura;
	cout << "\nBase : " << t.area() << endl;
}

Triangulo creaTriangulo()
{
	srand(time(0));
	double base = rand() % 10 + 1;
	double altura = rand() % 15 + 1;
	Triangulo t = {base, altura};
	return t;
}

Triangulo creaTriangulo(double base, double altura)
{
	Triangulo t = {base, altura};
	return t;
}
