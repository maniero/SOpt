#include <iostream>
using namespace std;

int main() {
    float n1, n2, resultado;
    int s;
    cout << "Digite um número para começar";
    cin >> n1;
    cout << endl << "Vc quer (1)somar (2)diminuir (3)mutiplicar (4)dividir";
    cin >> s;
    cout << endl << "Com qual valor?";
    cin >> n2;
    switch(s) {
    case 1:
        resultado = n1 + n2;
        break;
    case 2:
        resultado = n1 - n2;
        break;
    case 3:
        resultado = n1 * n2;
        break;
    case 4:
        resultado = n1 / n2;
        break;
    default:
        cout << endl << "Error 404";
        return 0;
    }
    cout << endl << "O resultado é " << resultado << endl;
}

//https://pt.stackoverflow.com/q/282205/101
