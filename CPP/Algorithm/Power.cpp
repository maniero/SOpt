#include <iostream>
#include <cmath>
using namespace std; 

int calc(int base) {
    return pow(base, 2);
}

int main() {   
    int vet[200];
    for (int x = 0; x < 200; x++) {
        vet[x] = x;
        cout << endl << "Posição " << x + 1 << " : " << vet[x];
    }
    for (int x = 0; x < 200; x++) cout << endl << vet[x] << "² =  " << calc(vet[x]);
}

//https://pt.stackoverflow.com/q/215776/101
