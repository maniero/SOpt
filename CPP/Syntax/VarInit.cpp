#include <stdlib.h>
#include <iostream>
using namespace std;

double square(double x) {
    double aux = 0;
    for (int i = 0; i < x; i++) aux += x;
    return aux;
}
int main() {
    double x;
    cout << "Digite um numero:\n";
    cin >> x;
    cout << "O numero " << x << " elevado ao quadrado eh: " << square(x) << "\n";
}

//https://pt.stackoverflow.com/q/108315/101
