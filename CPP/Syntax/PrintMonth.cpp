#include <iostream>
#include <string>

using namespace std;

int main() {
    int x = 0;
    cout << "Qual o mês atual Digite apenas um número de 0 a 12" << endl;
    cin >> x ;
    switch (x) {
        case 1 : cout << "Janeiro" << endl; break;
        case 2 : cout << "Fevereiro" << endl; break;
        case 3 : cout << "Março" << endl; break;
        case 4 : cout << "Abril" << endl; break;
        case 5 : cout << "Maio" << endl; break;
        case 6 : cout << "Junho" << endl; break;
        case 7 : cout << "Julho" << endl; break;
        case 8 : cout << "Agosto" << endl; break;
        case 9 : cout << "Setembro" << endl; break;
        case 10 : cout << "Outubro" << endl; break;
        case 11 : cout << "Novembro" << endl; break;
        case 12 : cout << "Dezembro" << endl; break;
        default : cout << "Digite um número de 0 à 12" << endl;
     }
 }
 
 //http://pt.stackoverflow.com/q/185988/101
