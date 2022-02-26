#include <iostream>

int main() {

    int valor1 = 10;

    int valor2 = 11;

    bool resultado;

    resultado = (++valor1 > valor2) && ( ++valor2 > 4);

    std::cout << valor2;

    return 0;

}