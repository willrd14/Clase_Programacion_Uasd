#ifdef __MSDOS__
    #include <iostream.h>
    #include <stdlib.h>
    #include <time.h>
#else
    #include <iostream>
    #include <cstdlib>
    #include <ctime>
    using namespace std;
#endif

int main (void)
{
    int jugada_del_ordenador, jugada_del_usuario;
    srand ((unsigned) time (NULL));
    cout << "Selecciona el valor de jugada del usuario." << endl;
    cout << "\t1.- Piedra" << endl;
    cout << "\t2.- Papel" << endl;
    cout << "\t3.- Tijera" << endl;
    cout << "\t: ";
    do {
        cin >> jugada_del_usuario;
        cin.get();
        if (jugada_del_usuario<1||jugada_del_usuario>3)
        {
            cout << "Valor incorrecto. Ingr\202salo nuevamente.: ";
        }
    } while (jugada_del_usuario<1||jugada_del_usuario>3);
    jugada_del_ordenador=1+rand()%3;
    if(jugada_del_ordenador==1)
        cout << "La jugada del ordenador es Piedra" << endl;
    if(jugada_del_ordenador==2)
        cout << "La jugada del ordenador es Papel" << endl;
    if(jugada_del_ordenador==3)
        cout << "La jugada del ordenador es Tijera" << endl;
    if(jugada_del_usuario==jugada_del_ordenador)
        cout << "Empate" << endl;
    if((jugada_del_usuario==1&&jugada_del_ordenador==3)||(jugada_del_usuario==2&&jugada_del_ordenador==1)||(jugada_del_usuario==3&&jugada_del_ordenador==2))
        cout << "Gana usuario" << endl;
    if((jugada_del_usuario==3&&jugada_del_ordenador==1)||(jugada_del_usuario==1&&jugada_del_ordenador==2)||(jugada_del_usuario==2&&jugada_del_ordenador==3))
        cout << "Gana ordenador" << endl;
    cout << "Valor de jugada del ordenador: " << jugada_del_ordenador << endl;
    cout << endl;
    system ("pause");
    return EXIT_SUCCESS;
}
