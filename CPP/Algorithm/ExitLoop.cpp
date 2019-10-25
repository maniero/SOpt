#include <iostream>
#include <locale>
#include <string>
using namespace std;

int main() {
    setlocale(LC_ALL, "portuguese");
    int idade[20];
    string nome[20];
    char sexo[20], expe[20];
    for (int i = 0; i < 3; i++) {
        do {
            cout << endl << "digite o seu " << i + 1 << "º nome, idade, sexo e se tem experiência no serviço: ";
            cin >> nome[i];
            cin >> idade[i];
            cin >> sexo[i];
            cin >> expe[i];
        } while (nome[i] == "0");
    }
}

//https://pt.stackoverflow.com/q/95926/101
