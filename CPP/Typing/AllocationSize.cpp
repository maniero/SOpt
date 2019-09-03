#include <iostream>
using namespace std;

struct Exemplo { int x; int b; };

int main() {
    Exemplo exemplo;
    cout << "Tamanho de exemplo: " << sizeof(exemplo) << endl;
    cout << "Valor de exemplo.x: " << exemplo.x << endl;
    cout << "Valor de exemplo.b: " << exemplo.b << endl;
    Exemplo *exemplo2 = new Exemplo;
    cout << "Tamanho de exemplo2: " << sizeof(exemplo2) << endl;
    cout << "Tamanho do objeto apontado por exemplo2: " << sizeof(*exemplo2) << endl;
    cout << "Valor de exemplo2 (o ponteiro): " << exemplo2 << endl;
    cout << "Valor de exemplo2->x: " << exemplo2->x << endl;
    cout << "Valor de exemplo2->b: " << exemplo2->b << endl;
    cout << "Tamanho de exemplo2.x: " << sizeof(exemplo2->x) << endl;
}

//https://pt.stackoverflow.com/q/58026/101
