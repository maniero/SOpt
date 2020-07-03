#include <iostream>
using namespace std;
#define SIZE 10

int main() {
    int valor[SIZE];
    for (int i = 0; i < SIZE; i++) {
        cout << "Digite o valor: ";
        cin >> valor[i];
    }
    int total = 0;
    for (int i = 0; i < 10; i++) {
    	cout << valor[i] << endl;
        total += valor[i];
    }
    cout << total;
}

//https://pt.stackoverflow.com/q/460614/101
