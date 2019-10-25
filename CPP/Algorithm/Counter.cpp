#include <iostream>
#include <locale.h>
using namespace std;

int getnegativo(int a, int b){
    if (a < 0)  b++;
    return b;
}

int main() {
    setlocale(LC_ALL, "portuguese");
    int cont, cot = 0;
    do {
        cout << "digite um valor: ";
        cin >> cont;
        cot = getnegativo(cont, cot);
    } while (cont != -1);
    cout << "número de valores negativos digitados: " << cot;
    cout << endl << endl;
}

//https://pt.stackoverflow.com/q/95827/101
