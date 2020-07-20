#include <iostream>
using namespace std;

void teste(int *t) {
    *t = 50;
}   

int main() {
    int x = 10;
    cout << "Sem usar o metodo com ponteiro: " << x << endl;
    teste(&x);
    cout << "Usando o metodo com ponteiro: " << x << endl;   
}

//https://pt.stackoverflow.com/q/295029/101
