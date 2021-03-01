#include <iostream>

using namespace std;

int main(){
	int numero;
	int cantNumerosEntre_1_y_9 = 0;
	int cantNumerosEntre_10_y_19 = 0;
	int cantNumerosEntre_20_y_29 = 0;
	int cantNumerosEntre_30_y_39 = 0;
	int cantNumerosEntre_40_y_49 = 0;
	int cantNumerosEntre_50_y_59 = 0;
	int cantNumerosEntre_60_y_69 = 0;
	int cantNumerosEntre_70_y_79 = 0;
	int cantNumerosEntre_80_y_89 = 0;
	int cantNumerosEntre_90_y_99 = 0;
	
	cout << "Introducir numero (-1 : Terminar) : ";
	cin >> numero;
		
	while ( numero != -1 )
	{
		if ( numero > 0 && numero < 100 ){
		
			switch ( numero / 10 )
			{
				case 0 : ++cantNumerosEntre_1_y_9; break;
				case 1 : ++cantNumerosEntre_10_y_19; break;
				case 2 : ++cantNumerosEntre_20_y_29; break;
				case 3 : ++cantNumerosEntre_30_y_39; break;
				case 4 : ++cantNumerosEntre_40_y_49; break;
				case 5 : ++cantNumerosEntre_50_y_59; break;
				case 6 : ++cantNumerosEntre_60_y_69; break;
				case 7 : ++cantNumerosEntre_70_y_79; break;
				case 8 : ++cantNumerosEntre_80_y_89; break;
				case 9 : ++cantNumerosEntre_90_y_99; break;
			}
		}else{
			cout << "Numero no permitido \n";
			}
		
		cout << "Introducir numero (-1 : Terminar) : ";
		cin >> numero;
	}
	
	
	cout << "Resultado: \n"
		 << "Cantidad de numeros ( 01-09 )" << cantNumerosEntre_1_y_9 << endl
		 << "Cantidad de numeros ( 10-19 )" << cantNumerosEntre_10_y_19 << endl
		 << "Cantidad de numeros ( 20-29 )" << cantNumerosEntre_20_y_29 << endl
		 << "Cantidad de numeros ( 30-39 )" << cantNumerosEntre_30_y_39 << endl
		 << "Cantidad de numeros ( 40-49 )" << cantNumerosEntre_40_y_49 << endl
		 << "Cantidad de numeros ( 50-59 )" << cantNumerosEntre_50_y_59 << endl
		 << "Cantidad de numeros ( 60-69 )" << cantNumerosEntre_60_y_69 << endl
		 << "Cantidad de numeros ( 70-79 )" << cantNumerosEntre_70_y_79 << endl
		 << "Cantidad de numeros ( 80-89 )" << cantNumerosEntre_80_y_89 << endl
		 << "Cantidad de numeros ( 90-99 )" << cantNumerosEntre_90_y_99 << endl
		 << endl;
	
	system("pause");
	return 0;
}
