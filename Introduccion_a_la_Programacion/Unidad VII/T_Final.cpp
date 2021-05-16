#include <iostream>
#include <fstream>
#include <iomanip>
#include <cstdlib>
#include <cstring>

using namespace std;

struct Persona
{
	char nombre[45] = "";
	char apellido[30] = "";
	char apellido2[30] = "";
	long cedula = 0;
};

int menu()
{
	int x = 0;
	cout << "1. Agregar"   << endl;
	cout << "2. Listar"    << endl;
	cout << "3. Buscar"    << endl;
	cout << "4. Eliminar"  << endl;
	cout << "5. Modificar" << endl;
	cout << "6. Salir" 	   << endl;
	cout << "Opcion: ";
	cin >> x;
	return x;
}

long getLong(string mjs)
{
	long m;
	cout << mjs << endl;
	cin >> m;
	return m;
}

string getString(string mjs)
{
	string m;
	cout << mjs << endl;
	getline(cin, m);
	return m;
}

Persona getPersona(long ced)
{
	fstream e("archivos.txt", ios::out | ios::in | ios::binary);
	Persona aux;
	if(e.is_open())
	{
		e.seekg((ced - 1) * sizeof(Persona));
		e.read((char*)&aux, sizeof(Persona));
		e.close();
	}
	return aux;
}

void agregarRegistro()
{
	Persona p;
	cin.ignore();
	strcpy(p.nombre, getString("Ingresar nombre").c_str());
	strcpy(p.apellido, getString("Ingresar apellido").c_str());
	strcpy(p.apellido2, getString("Ingresar apellido2").c_str());
	p.cedula = getLong("Numero de cedula");
	Persona aux = getPersona(p.cedula);
	if(aux.cedula != 0)
	{
		cout << "Registro ya existente." << endl;
	}else{
		fstream e("archivos.txt", ios::out | ios::in | ios::binary);
		if(e.is_open())
		{
			e.seekp((p.cedula - 1) * sizeof(Persona));
			e.write((char*)&p, sizeof(Persona));
			e.close();
		}
	}
}

void mostrar(Persona p){
	cout << "-------------------------" << endl;
	cout << "Nombre---------- "   	    << p.nombre 	<< endl;
	cout << "Apellido-------- "  		<< p.apellido   << endl;
	cout << "Apellido2------- " 		<< p.apellido2  << endl;
	cout << "Cedula---------- " 		<< p.cedula 	<< endl;
	cout << "-------------------------" << endl;
}

void listarRegistro(){
	fstream e("archivos.txt", ios::out | ios::in | ios::binary);
	Persona aux;
	if(e.is_open())
	{
		e.read((char*)&aux, sizeof(Persona));
		while(!e.eof()){
			if(aux.cedula != 0)
				mostrar(aux);
			e.read((char*)&aux, sizeof(Persona));
		}
		e.close();
	}
}

void buscarRegistro()
{
	int long ced = getLong("Digite el numero de cedula");
	Persona aux = getPersona(ced);
	if(aux.cedula == 0)
	{
		cout << "No existe registro" << endl;
	}else{
		mostrar(aux);
	}
	
}

void eliminar(int long ced)
{
	fstream e("archivos.txt", ios::out | ios::in | ios::binary);
	Persona aux;
	if(e.is_open()){
		e.seekp((aux.cedula - 1) * sizeof(Persona));
		e.write((char*)&aux, sizeof(Persona));
		e.close();
	}
}

void eliminarRegistro()
{
	int long ced = getLong("Cedula de registro a eliminar ");
	Persona aux = getPersona(ced);
	if(aux.cedula == 0){
		cout << "No existe registro" << endl;
	}else{
		cout << "Registro eliminado" << endl;
		eliminar(ced);
	}
}

void modificarRegistro()
{
	int long ced = getLong("Digite la cedula");
	Persona aux = getPersona(ced);
	cin.ignore();
	if(aux.cedula == 0){
		cout << "No existe registro" << endl;
	}else{
		mostrar(aux);
		strcpy(aux.nombre, getString("Ingresar nombre").c_str());
		strcpy(aux.apellido, getString("Ingresar apellido").c_str());
		strcpy(aux.apellido2, getString("Ingresar apellido2").c_str());
		
		fstream e("archivos.txt", ios::out | ios::in | ios::binary);
		if(e.is_open())
		{
			e.seekp((aux.cedula - 1) * sizeof(Persona));
			e.write((char*)&aux, sizeof(Persona));
			e.close();
		}
	}
}

int main()
{
	int x = 0;
	
	do{
		x = menu();
		switch(x){
			case 1:
				agregarRegistro();
				break;
			case 2:
				listarRegistro();
				break;
			case 3:
				buscarRegistro();
				break;
			case 4:
				eliminarRegistro();
				break;
			case 5
			:
				modificarRegistro();
				break;
		}
	}
	while(x != 6);
	
	return 0;
}
