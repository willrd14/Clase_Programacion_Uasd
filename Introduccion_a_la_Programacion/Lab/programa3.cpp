#include <stdio.h>

long potenciaRecursiva(long numero, long potencia)
{
    if (potencia <= 0)
    {
        return 1;
    }
    else
    {
        return numero * potenciaRecursiva(numero, potencia - 1);
    }
}

long potenciaConWhile(long numero, long potencia)
{
    long resultado = numero;
    while (potencia > 1)
    {
        resultado = resultado * numero;
        potencia--;
    }
    return resultado;
}

int main()
{
    long potencia = 3; // Al cubo
    long numero = 9;
    long elevadoAlCubo = potenciaRecursiva(numero, potencia);
    printf("Probando con recursividad. %ld elevado a %ld es %ld\n", numero, potencia, elevadoAlCubo);
    long elevadoConWhile = potenciaConWhile(numero, potencia);
    printf("Probando con while. %ld elevado a %ld es %ld\n", numero, potencia, elevadoAlCubo);
}
