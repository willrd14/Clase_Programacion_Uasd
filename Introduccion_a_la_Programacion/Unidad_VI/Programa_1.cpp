#include <iostream>
 
using namespace std;
 
double* creaArreglo(int);
void leePuntuaciones(double*, int);
void ordena(double*, int);
void intercambio(double*, double*);
void imprimeArreglo(double*, int);
double calculaPromedio(double*, int);
 
int main()
{
    int sz;
 
    cout << "\nPuntuaciones: "; cin >> sz;
    double* v = creaArreglo(sz);
 
    cout << "\nPuntuaciones: " << endl;
    leePuntuaciones(v, sz);
 
    ordena(v, sz);
    cout << "\nArreglo ordenado: ";
    imprimeArreglo(v, sz);
 
    cout << "\n\nPromedio: " << calculaPromedio(v, sz) << endl;
 
    return 0;
}
 
double* creaArreglo(int sz)
{
    double* v = new double[sz];
 
    return v;
}
 
void leePuntuaciones(double* v, int sz)
{
    for (int i = 0; i < sz; i++)
    {
        cout << "(" << i + 1 << "/" << sz << "): ";
        cin >> v[i];
     }
}
 
void ordena(double* v, int sz)
{
    for( int i = 0; i < sz-1; i++ )
    {
        for (int j = 0; j < sz-i-1; j++)
        {
            if (v[j] > v[j+1])
                intercambio(&v[j], &v[j+1]);
        }
   }
}
 
void intercambio(double *a, double *b)
{
    int temp = *a;
    *a = *b;
    *b = temp;
}
 
void imprimeArreglo(double* v, int sz)
{
    for (int i = 0; i < sz; i++)
        cout << v[i] << " ";
}
 
double calculaPromedio(double* v, int sz)
{
    double suma = 0.0f;
 
    for (int i = 0; i < sz; i++)
        suma += v[i];
 
    return suma / float(sz);
}
