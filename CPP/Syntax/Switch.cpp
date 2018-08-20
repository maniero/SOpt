#include <iostream>
using namespace std;

int main() {
    int item, qtde;
    float valor;
    cin >> item >> qtde;
    switch (item) {
    case 1:
        valor = 4.00;
        break;
    case 2:
        valor = 4.50;
        break;
    case 3:
        valor = 5.00;
        break;
    case 4:
        valor = 2.00;
        break;
    case 5:
        valor = 1.50;
        break;
    }
    cout << "Total: R$" << valor * qtde;
}

//https://pt.stackoverflow.com/q/322871/101
