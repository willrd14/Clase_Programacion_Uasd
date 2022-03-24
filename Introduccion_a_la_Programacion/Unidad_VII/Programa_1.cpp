#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	fstream dataFile;
	
	cout << "Localizando archivo\n"
		 << "....\n"
		 << "....\n"
		 << "....\n"
		 << "Archivo localizado\n"
		 << "Abriendo archivo" << endl;
	dataFile.open("lib.txt", ios::app);
	
	cout 	 << "Escribiendo en el archivo....\n";
	dataFile << "1: George Rolland\n";
	dataFile << "2: 127 Academy Street\n";
	dataFile << "3: Brasstown, NC 28706\n";
	
	cout << "Cerrando archivo...\n";
	dataFile.close();
	
	cout << "Fin del Programa, Gracias por utilizarnos...\n";
	return 0;
}
