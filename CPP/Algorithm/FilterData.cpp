#include <iostream>
#include <locale.h>
#include <string.h>
#include <stdio.h>

using namespace std;

int main() {
    setlocale(LC_ALL, "portuguese");
    int idade, cont = 0;
    string pro[23];
    string nome[23];
    string nr[23];
    for (int i = 0; i < 2; i++) {
        cout << "Digite o seu " << i + 1 <<"º nome, profissão e idade: ";
        cin >> nome[i];
        cin >> pro[i];
        cin >> idade;
        if (idade >= 18) nr[cont++] = nome[i];
    }
    cout << "número de pessoas maior de 18 anos: " << cont << endl;
    for (int i = 0; i < cont; i++) cout << "nome: " << nr[i] << endl;
}

//https://pt.stackoverflow.com/q/95720/101
