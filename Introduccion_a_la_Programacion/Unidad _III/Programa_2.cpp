#include <iostream>
#include <string>

 using namespace std;

 string leerNombre(){

	 string nombre="";

	 cout<<"Introduzca Su Nombre: "<<endl;

	 cin>>nombre;

	 cout<<endl;
	 
	 return nombre;

 }

 

 string leerApellido(){
 	
	 string apellido="";

	 cout<<"Introduzca Su Apellido: "<<endl;

	 cin>>apellido;

	 cout<<endl;

	 return apellido;

 }

 void imprimirNombApell(string nombre, string apellido){

	 string cadena= nombre +" "+apellido;

	 for(string::iterator it=cadena.begin(); it<cadena.end();it++){

		 cout<<*it;

		 cout<<endl;

	 }

 }

 int main(){

	 string n=leerNombre();

	 string a=leerApellido();

	 imprimirNombApell(n,a);

	system ("pause");
	 return 0;

 }
