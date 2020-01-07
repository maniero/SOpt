#include <iostream>
#include <vector>
using namespace std;

void imprime(vector<int>& v) {
    for(int x = 0; x < v.size(); x++) cout << v[x] << " ";
}

void fibonacci(int x, int y, vector<int>& fi) {
    int z = 0;
    for (int b = 0; b < fi.size(); b++) {
        z = x + y;
        fi[b] = z;
        x = y;
        y = z;      
    }           
}

int main() {
    int valor1, valor2, numeroElementos;
    while (cin >> valor1 >> valor2 >> numeroElementos) {
	 	vector<int> numeros(numeroElementos);
        fibonacci(valor1, valor2, numeros);
        imprime(numeros);
    }
}

//https://pt.stackoverflow.com/q/126405/101
