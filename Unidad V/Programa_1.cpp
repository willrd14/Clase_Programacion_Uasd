#include <iostream>
 
int fibonacci( int n )
{
    if( n == 0 || n == 1 )
       return n;
    else
       return fibonacci(n - 2) + fibonacci(n - 1);
}
 
int main()
{
    int n;
    int i = 0;;
 
    std::cout << "\nIntroduce un numero: "; std::cin >> n;
 
    std::cout<<"\nLa serie es: ";
 
    while( true ) {
        if( fibonacci(i) > n )
            break;
        if( fibonacci(i) != 0 )
          std::cout << ", ";
 
        std::cout << fibonacci(i);
        i++;
    }
 
    std::cout << std::endl;
 
    return 0;
}
