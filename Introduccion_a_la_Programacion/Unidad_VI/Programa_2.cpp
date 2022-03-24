#include <iostream>
 
using namespace std;
 
int* redimensionar(int *v,int longitud, int newSz);
 
int main()
{
    int sz, newSz;
    cout << "\nTamanio: ";
    cin >> sz;
 
    int *v = new int[sz];
 
    cout << endl;
    for(int i = 0; i < sz; i++)
    {
        cout << "[" << i << "]: ";
        cin >> v[i];
    }
 
    cout << "\nNuevo Tamanio: ";
    cin >> newSz;
 
    int *ptr = redimensionar(v, sz, newSz);
 
    cout << "\nVector redimensionado: ";
    for(int i = 0; i < newSz; i++)
        cout << ptr[i] << " ";
 
    cout << endl;
 
    return 0;
}
 
int* redimensionar(int *v, int sz, int newSz)
{
    int *newV = new int[newSz];
 
    for (int i = 0; i < newSz; i++)
    {
        if (sz <= i)
            newV[i] = 0;
        else
            newV[i] = v[i];
    }
 
    delete[] v;
 
    return newV;
}
