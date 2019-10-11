#include <iostream>
#include <cstdlib>
#include <fstream>
#include <string>
using namespace std;

void apaga_espaco(ifstream& tabe) {
    string s;
    char N;
    while (tabe.good()) {
        getline(tabe, s);
        s.erase(0, 29);
        N = s.find(':');
        s.erase(0, N + 6);
    }
}

int main() {
    ifstream tabe;
    char N;
    tabe.open("Tabela.txt", ios::in);
    if (!tabe.is_open()) {
        cout << "Arquivo nao encontrado, erro fatal!";
        exit(1);
    }
    apaga_espaco(tabe);
}

//https://pt.stackoverflow.com/q/89536/101
